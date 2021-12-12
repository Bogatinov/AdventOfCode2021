using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day02Tests : DayAdventFixture<int>
    {
        public Day02Tests() : base(new Day02("Puzzles/day02.txt"))
        {
        }

        protected override int Expected1 => 1427868;

        protected override int Expected2 => 1568138742;
    }

    public class Day02TrainTests : DayAdventFixture<int>
    {
        public Day02TrainTests() : base(new Day02("Puzzles/day02_train.txt"))
        {
        }

        protected override int Expected1 => 150;

        protected override int Expected2 => 900;
    }
}
