using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public class Day07Tests : DayAdventFixture<int>
    {
        public Day07Tests() : base(new Day07("Puzzles/day07.txt"))
        {
        }

        protected override int Expected1 => 356992;

        protected override int Expected2 => 101268110;
    }

    public class Day07TrainTests : DayAdventFixture<int>
    {
        public Day07TrainTests() : base(new Day07("Puzzles/day07_train.txt"))
        {
        }

        protected override int Expected1 => 37;

        protected override int Expected2 => 168;
    }
}
