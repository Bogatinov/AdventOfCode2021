using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day09Tests : DayAdventFixture<int>
    {
        public Day09Tests() : base(new Day09("Puzzles/day09.txt"))
        {
        }

        protected override int Expected1 => 423;

        protected override int Expected2 => 1198704;
    }

    public class Day09TrainTests : DayAdventFixture<int>
    {
        public Day09TrainTests() : base(new Day09("Puzzles/day09_train.txt"))
        {
        }

        protected override int Expected1 => 15;

        protected override int Expected2 => 1134;
    }
}
