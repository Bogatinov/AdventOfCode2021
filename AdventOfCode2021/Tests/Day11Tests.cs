using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day11Tests : DayAdventFixture<int>
    {
        public Day11Tests() : base(new Day11("Puzzles/day11.txt"))
        {
        }

        protected override int Expected1 => 1620;

        protected override int Expected2 => 371;
    }

    public class Day11TrainTests : DayAdventFixture<int>
    {
        public Day11TrainTests() : base(new Day11("Puzzles/day11_train.txt"))
        {
        }

        protected override int Expected1 => 1656;

        protected override int Expected2 => 195;
    }
}
