using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day08Tests : DayAdventFixture<int>
    {
        public Day08Tests() : base(new Day08("Puzzles/day08.txt"))
        {
        }

        protected override int Expected1 => 278;

        protected override int Expected2 => 986179;
    }

    public class Day08TrainTests : DayAdventFixture<int>
    {
        public Day08TrainTests() : base(new Day08("Puzzles/day08_train.txt"))
        {
        }

        protected override int Expected1 => 26;

        protected override int Expected2 => 61229;
    }
}
