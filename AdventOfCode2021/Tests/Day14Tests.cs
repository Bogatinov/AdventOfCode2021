using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day14Tests : DayAdventFixture<long>
    {
        public Day14Tests() : base(new Day14("Puzzles/day14.txt"))
        {
        }

        protected override long Expected1 => 4244;

        protected override long Expected2 => 4807056953866;
    }

    public class Day14TrainTests : DayAdventFixture<long>
    {
        public Day14TrainTests() : base(new Day14("Puzzles/day14_train.txt"))
        {
        }

        protected override long Expected1 => 1588;

        protected override long Expected2 => 2188189693529;
    }
}
