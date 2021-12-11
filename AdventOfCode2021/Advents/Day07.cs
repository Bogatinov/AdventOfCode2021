namespace AdventOfCode2021.Advents
{
    public class Day07 : DayAdvent<int>
    {
        private readonly List<int> _numbers;
        private readonly int _sum;

        public Day07(string filePath) : base(filePath)
        {
            _numbers = new();
            foreach (var value in Lines[0].Split(','))
            {
                int number = int.Parse(value);
                _sum += number;
                _numbers.Add(number);
            }
            _numbers.Sort();
        }

        public override int Solve1()
        {
            int median = _numbers[_numbers.Count / 2];

            int result = 0;
            foreach (int number in _numbers)
            {
                result += Math.Abs(number - median);
            }

            return result;
        }

        public override int Solve2()
        {
            int lowAvg = _sum / _numbers.Count;
            int highAvg = lowAvg + 1;

            int lowResult = 0;
            int highResult = 0;
            foreach (int number in _numbers)
            {
                int minDiff = Math.Abs(number - lowAvg);
                lowResult += minDiff * (minDiff + 1) / 2;

                int maxDiff = Math.Abs(number - highAvg);
                highResult += maxDiff * (maxDiff + 1) / 2;
            }

            return Math.Min(lowResult, highResult);
        }
    }
}
