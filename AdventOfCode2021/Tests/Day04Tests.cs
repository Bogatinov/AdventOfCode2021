using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day04Tests : DayAdventFixture<int>
    {
        public Day04Tests() : base(new Day04("Puzzles/day04.txt"))
        {
        }

        [Fact(DisplayName = "Day04 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(49686, result);
        }

        [Fact(DisplayName = "Day04 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(26878, result);
        }
    }

    public class Day04TrainTests : DayAdventFixture<int>
    {
        public Day04TrainTests() : base(new Day04("Puzzles/day04_train.txt"))
        {
        }

        [Fact(DisplayName = "Day04 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(4512, result);
        }

        [Fact(DisplayName = "Day04 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(1924, result);
        }
    }
}
