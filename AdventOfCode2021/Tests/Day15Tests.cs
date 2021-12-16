using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day15Tests : DayAdventFixture<int>
    {
        public Day15Tests() : base(new Day15("Puzzles/day15.txt"))
        {
        }

        protected override int Expected1 => 415;

        protected override int Expected2 => 2864;
    }

    public class Day15TrainTests : DayAdventFixture<int>
    {
        public Day15TrainTests() : base(new Day15("Puzzles/day15_train.txt"))
        {
        }

        protected override int Expected1 => 40;

        protected override int Expected2 => 315;
    }
}
