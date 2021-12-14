using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day13Tests : DayAdventFixture<string>
    {
        public Day13Tests() : base(new Day13("Puzzles/day13.txt"))
        {
        }

        protected override string Expected1 => "682";

        protected override string Expected2 => "####..##...##..#..#.###..####.#..#.####\r\n#....#..#.#..#.#..#.#..#....#.#..#.#...\r\n###..#..#.#....#..#.#..#...#..####.###.\r\n#....####.#.##.#..#.###...#...#..#.#...\r\n#....#..#.#..#.#..#.#.#..#....#..#.#...\r\n#....#..#..###..##..#..#.####.#..#.####\r\n";
    }

    public class Day13TrainTests : DayAdventFixture<string>
    {
        public Day13TrainTests() : base(new Day13("Puzzles/day13_train.txt"))
        {
        }

        protected override string Expected1 => "17";

        protected override string Expected2 => "#####\r\n#...#\r\n#...#\r\n#...#\r\n#####\r\n";
    }
}
