using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day06Tests : DayAdventFixture<long>
    {
        public Day06Tests() : base(new Day06("Puzzles/day06.txt"))
        {
        }

        [Fact(DisplayName = "Day06 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(363101, result);
        }

        [Fact(DisplayName = "Day06 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1644286074024, result);
        }
    }

    public class Day06TrainTests : DayAdventFixture<long>
    {
        public Day06TrainTests() : base(new Day06("Puzzles/day06_train.txt"))
        {
        }

        [Fact(DisplayName = "Day06 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(5934, result);
        }

        [Fact(DisplayName = "Day06 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(26984457539, result);
        }
    }
}
