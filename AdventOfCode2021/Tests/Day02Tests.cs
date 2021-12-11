using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day02Tests : DayAdventFixture<int>
    {
        public Day02Tests() : base(new Day02("Puzzles/day02.txt"))
        {
        }

        [Fact(DisplayName = "Day02 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(1427868, result);
        }

        [Fact(DisplayName = "Day02 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1568138742, result);
        }
    }

    public class Day02TrainTests : DayAdventFixture<int>
    {
        public Day02TrainTests() : base(new Day02("Puzzles/day02_train.txt"))
        {
        }

        [Fact(DisplayName = "Day02 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(150, result);
        }

        [Fact(DisplayName = "Day02 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(900, result);
        }
    }
}
