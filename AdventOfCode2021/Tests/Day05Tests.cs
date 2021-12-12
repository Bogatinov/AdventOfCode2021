using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day05Tests : DayAdventFixture<int>
    {
        public Day05Tests() : base(new Day05("Puzzles/day05.txt"))
        {
        }

        protected override int Expected1 => 7414;

        protected override int Expected2 => 19676;
    }

    public class Day05TrainTests : DayAdventFixture<int>
    {
        public Day05TrainTests() : base(new Day05("Puzzles/day05_train.txt"))
        {
        }

        protected override int Expected1 => 5;

        protected override int Expected2 => 12;
    }
}
