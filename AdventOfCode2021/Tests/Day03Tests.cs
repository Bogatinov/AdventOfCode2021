using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day03Tests : DayAdventFixture<int>
    {
        public Day03Tests() : base(new Day03("Puzzles/day03.txt"))
        {
        }

        protected override int Expected1 => 1997414;

        protected override int Expected2 => 1032597;
    }

    public class Day03TrainTests : DayAdventFixture<int>
    {
        public Day03TrainTests() : base(new Day03("Puzzles/day03_train.txt"))
        {
        }

        protected override int Expected1 => 198;

        protected override int Expected2 => 230;
    }
}
