namespace AdventOfCode2021.Advents
{
    public class Day02 : DayAdvent<int>
    {
        public Day02(string filePath) : base(filePath)
        {

        }

        public override int Solve1()
        {
            int horizontal = 0;
            int depth = 0;
            foreach (string line in Lines)
            {
                switch (line[0])
                {
                    case 'f':
                        horizontal += line[^1] - '0';
                        break;
                    case 'd':
                        depth += line[^1] - '0';
                        break;
                    case 'u':
                        depth -= line[^1] - '0';
                        break;
                }
            }

            return horizontal * depth;
        }

        public override int Solve2()
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;
            foreach (string line in Lines)
            {
                int units = line[^1] - '0';

                switch (line[0])
                {
                    case 'f':
                        horizontal += units;
                        depth += aim * units;
                        break;
                    case 'd':
                        aim += units;
                        break;
                    case 'u':
                        aim -= units;
                        break;
                }
            }

            return horizontal * depth;
        }
    }
}
