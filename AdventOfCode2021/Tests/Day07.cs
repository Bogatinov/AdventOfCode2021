using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day07Tests : DayAdventFixture<int>
    {
        public Day07Tests() : base(new Day07("Puzzles/day07.txt"))
        {
        }

        [Fact(DisplayName = "Day07 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(356992, result);
        }

        [Fact(DisplayName = "Day07 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(101268110, result);
        }
    }

    public class Day07TrainTests : DayAdventFixture<int>
    {
        public Day07TrainTests() : base(new Day07("Puzzles/day07_train.txt"))
        {
        }

        [Fact(DisplayName = "Day07 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(37, result);
        }

        [Fact(DisplayName = "Day07 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(168, result);
        }
    }
}
