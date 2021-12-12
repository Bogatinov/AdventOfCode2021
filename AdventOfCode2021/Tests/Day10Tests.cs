using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day10Tests : DayAdventFixture<long>
    {
        public Day10Tests() : base(new Day10("Puzzles/day10.txt"))
        {
        }

        [Fact(DisplayName = "Day10 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(193275, result);
        }

        [Fact(DisplayName = "Day10 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(2429644557, result);
        }
    }

    public class Day10TrainTests : DayAdventFixture<long>
    {
        public Day10TrainTests() : base(new Day10("Puzzles/day10_train.txt"))
        {
        }

        [Fact(DisplayName = "Day10 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(26397, result);
        }

        [Fact(DisplayName = "Day10 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(288957, result);
        }
    }
}
