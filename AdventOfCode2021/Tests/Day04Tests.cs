using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day04Tests : DayAdventFixture<int>
    {
        public Day04Tests() : base(new Day04("Puzzles/day04.txt"))
        {
        }

        protected override int Expected1 => 49686;

        protected override int Expected2 => 26878;
    }

    public class Day04TrainTests : DayAdventFixture<int>
    {
        public Day04TrainTests() : base(new Day04("Puzzles/day04_train.txt"))
        {
        }

        protected override int Expected1 => 4512;

        protected override int Expected2 => 1924;
    }
}
