using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class Day05Tests : DayAdventFixture<int>
    {
        public Day05Tests() : base(new Day05("Puzzles/day05.txt"))
        {
        }

        [Fact(DisplayName = "Day05 Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(7414, result);
        }

        [Fact(DisplayName = "Day05 Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(19676, result);
        }
    }

    public class Day05TrainTests : DayAdventFixture<int>
    {
        public Day05TrainTests() : base(new Day05("Puzzles/day05_train.txt"))
        {
        }

        [Fact(DisplayName = "Day05 Train Solve01")]
        public override void Solve1()
        {
            var result = Day.Solve1();

            Assert.Equal(5, result);
        }

        [Fact(DisplayName = "Day05 Train Solve02")]
        public override void Solve2()
        {
            var result = Day.Solve2();

            Assert.Equal(12, result);
        }
    }
}
