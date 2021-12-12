using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day09Tests : DayAdventFixture<int>
    {
        public Day09Tests() : base(new Day09("Puzzles/day09.txt"))
        {
        }

        [Fact(DisplayName = "Day09 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(423, result);
        }

        [Fact(DisplayName = "Day09 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1198704, result);
        }
    }

    public class Day09TrainTests : DayAdventFixture<int>
    {
        public Day09TrainTests() : base(new Day09("Puzzles/day09_train.txt"))
        {
        }

        [Fact(DisplayName = "Day09 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(15, result);
        }

        [Fact(DisplayName = "Day09 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1134, result);
        }
    }
}
