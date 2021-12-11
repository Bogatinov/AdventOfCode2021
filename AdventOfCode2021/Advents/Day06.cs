namespace AdventOfCode2021.Advents
{
    public class Day06 : DayAdvent<long>
    {
        private readonly long[] lives;

        public Day06(string filePath) : base(filePath)
        {
            lives = new long[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (var line in Lines[0].Split(","))
            {
                lives[int.Parse(line) + 1]++;
            }
        }

        public override long Solve1() => Solve(80);

        public override long Solve2() => Solve(256);

        private long Solve(int days)
        {
            short maxLife = 9;
            for (int day = 0; day <= days; day++)
            {
                lives[(day + 7) % maxLife] += lives[day % maxLife];
            }

            long result = 0;
            for (int i = 0; i < lives.Length; i++)
            {
                result += lives[i];
            }

            return result;
        }
    }
}
