using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day11Tests : DayAdventFixture<int>
    {
        public Day11Tests() : base(new Day11("Puzzles/day11.txt"))
        {
        }

        [Fact(DisplayName = "Day11 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(1620, result);
        }

        [Fact(DisplayName = "Day11 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(371, result);
        }
    }

    public class Day11TrainTests : DayAdventFixture<int>
    {
        public Day11TrainTests() : base(new Day11("Puzzles/day11_train.txt"))
        {
        }

        [Fact(DisplayName = "Day11 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(1656, result);
        }

        [Fact(DisplayName = "Day11 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(195, result);
        }
    }
}
