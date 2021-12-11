using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day01TrainTests : DayAdventFixture<int>
    {
        public Day01TrainTests() : base(new Day01("Puzzles/day01_train.txt"))
        {
        }

        [Fact(DisplayName = "Day01 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(7, result);
        }

        [Fact(DisplayName = "Day01 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(5, result);
        }
    }

    public class Day01Tests : DayAdventFixture<int>
    {
        public Day01Tests() : base(new Day01("Puzzles/day01.txt"))
        {
        }

        [Fact(DisplayName = "Day01 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(1713, result);
        }

        [Fact(DisplayName = "Day01 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1734, result);
        }
    }
}
