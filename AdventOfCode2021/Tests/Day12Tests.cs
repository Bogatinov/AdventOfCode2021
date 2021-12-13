using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day12Tests : DayAdventFixture<int>
    {
        public Day12Tests() : base(new Day12("Puzzles/day12.txt"))
        {
        }

        protected override int Expected1 => 4104;

        protected override int Expected2 => 119760;
    }

    public class Day12TrainTests : DayAdventFixture<int>
    {
        public Day12TrainTests() : base(new Day12("Puzzles/day12_train.txt"))
        {
        }

        protected override int Expected1 => 226;

        protected override int Expected2 => 3509;
    }
}
