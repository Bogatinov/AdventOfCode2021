namespace AdventOfCode2021.Advents
{
    public class Day14 : DayAdvent<long>
    {
        private readonly Dictionary<PairKey, long> _pairCounters;
        private readonly Dictionary<char, long> _letterCounters;
        private readonly Dictionary<PairKey, char> _rules;

        public Day14(string filePath) : base(filePath)
        {
            _letterCounters = new();
            foreach (char item in Lines[0])
            {
                _letterCounters.TryGetValue(item, out long value);
                _letterCounters[item] = value + 1;
            }

            _pairCounters = new();
            for (int i = 1; i < Lines[0].Length; i++)
            {
                var key = new PairKey(Lines[0][i - 1], Lines[0][i]);
                _pairCounters.TryGetValue(key, out var count);
                _pairCounters[key] = count + 1;
            }

            _rules = new();
            for (int i = 2; i < Lines.Length; i++)
            {
                _rules[new PairKey(Lines[i][0], Lines[i][1])] = Lines[i][6];
            }
        }

        public override long Solve1() => Mutate(10);

        public override long Solve2() => Mutate(40);

        private long Mutate(int steps)
        {
            var iterator = _pairCounters;
            for (int i = 0; i < steps; i++)
            {
                iterator = Step(iterator);
            }

            return _letterCounters.Values.Max() - _letterCounters.Values.Min();
        }

        private Dictionary<PairKey, long> Step(Dictionary<PairKey, long> iterator)
        {
            Dictionary<PairKey, long> result = new();

            foreach (var letterCount in iterator)
            {
                char key = _rules[letterCount.Key];
                _letterCounters.TryGetValue(key, out var frequency);
                _letterCounters[key] = letterCount.Value + frequency;

                var key1 = new PairKey(letterCount.Key.First, _rules[letterCount.Key]);
                result.TryGetValue(key1, out var frequency1);
                result[key1] = letterCount.Value + frequency1;

                var key2 = new PairKey(_rules[letterCount.Key], letterCount.Key.Second);
                result.TryGetValue(key2, out var frequency2);
                result[key2] = letterCount.Value + frequency2;
            }

            return result;
        }
    }

    public struct PairKey : IEquatable<PairKey>
    {
        public PairKey(char firstLetter, char secondLetter)
        {
            First = firstLetter;
            Second = secondLetter;
        }

        public char First { get; }
        public char Second { get; }

        public bool Equals(PairKey other)
        {
            return First == other.First && Second == other.Second;
        }

        public override int GetHashCode()
        {
            return First.GetHashCode() ^ Second.GetHashCode();
        }
    }
}
