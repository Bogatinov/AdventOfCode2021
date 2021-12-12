using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day10Tests : DayAdventFixture<long>
    {
        public Day10Tests() : base(new Day10("Puzzles/day10.txt"))
        {
        }

        protected override long Expected1 => 193275;

        protected override long Expected2 => 2429644557;
    }

    public class Day10TrainTests : DayAdventFixture<long>
    {
        public Day10TrainTests() : base(new Day10("Puzzles/day10_train.txt"))
        {
        }

        protected override long Expected1 => 26397;

        protected override long Expected2 => 288957;
    }
}
