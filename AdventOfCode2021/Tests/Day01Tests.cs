using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day01TrainTests : DayAdventFixture<int>
    {
        public Day01TrainTests() : base(new Day01("Puzzles/day01_train.txt"))
        {
        }

        protected override int Expected1 => 7;

        protected override int Expected2 => 5;
    }

    public class Day01Tests : DayAdventFixture<int>
    {
        public Day01Tests() : base(new Day01("Puzzles/day01.txt"))
        {
        }

        protected override int Expected1 => 1713;

        protected override int Expected2 => 1734;
    }
}
