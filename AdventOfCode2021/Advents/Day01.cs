namespace AdventOfCode2021.Advents
{
    public class Day01 : DayAdvent<int>
    {
        private readonly List<int> _numbers;

        public Day01(string filePath) : base(filePath)
        {
            _numbers = new(Lines.Length);

            foreach (var line in Lines)
            {
                _numbers.Add(int.Parse(line));
            }
        }

        public override int Solve1()
        {
            int result = 0;
            for (int i = 1; i < _numbers.Count; i++)
            {
                if (_numbers[i - 1] < _numbers[i])
                {
                    result++;
                }
            }
            return result;
        }

        public override int Solve2()
        {
            var result = 0;
            for (int i = 1, n = _numbers.Count - 2; i < n; i++)
            {
                if (_numbers[i + 2] > _numbers[i - 1])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
