using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day08Tests : DayAdventFixture<int>
    {
        public Day08Tests() : base(new Day08("Puzzles/day08.txt"))
        {
        }

        [Fact(DisplayName = "Day08 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(278, result);
        }

        [Fact(DisplayName = "Day08 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(986179, result);
        }
    }

    public class Day08TrainTests : DayAdventFixture<int>
    {
        public Day08TrainTests() : base(new Day08("Puzzles/day08_train.txt"))
        {
        }

        [Fact(DisplayName = "Day08 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(26, result);
        }

        [Fact(DisplayName = "Day08 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(61229, result);
        }
    }
}
