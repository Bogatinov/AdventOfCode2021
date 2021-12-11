using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day03Tests : DayAdventFixture<int>
    {
        public Day03Tests() : base(new Day03("Puzzles/day03.txt"))
        {
        }

        [Fact(DisplayName = "Day03 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(1997414, result);
        }

        [Fact(DisplayName = "Day03 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1032597, result);
        }
    }

    public class Day03TrainTests : DayAdventFixture<int>
    {
        public Day03TrainTests() : base(new Day03("Puzzles/day03_train.txt"))
        {
        }

        [Fact(DisplayName = "Day03 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(198, result);
        }

        [Fact(DisplayName = "Day03 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(230, result);
        }
    }
}
