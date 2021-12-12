using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day06Tests : DayAdventFixture<long>
    {
        public Day06Tests() : base(new Day06("Puzzles/day06.txt"))
        {
        }

        protected override long Expected1 => 363101;

        protected override long Expected2 => 1644286074024;
    }

    public class Day06TrainTests : DayAdventFixture<long>
    {
        public Day06TrainTests() : base(new Day06("Puzzles/day06_train.txt"))
        {
        }

        protected override long Expected1 => 5934;

        protected override long Expected2 => 26984457539;
    }
}
