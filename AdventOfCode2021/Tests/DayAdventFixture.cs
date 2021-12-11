using AdventOfCode2021.Advents;

namespace AdventOfCode2021.Tests
{
    public abstract class DayAdventFixture<T>
    {
        protected readonly DayAdvent<T> Day;
        public DayAdventFixture(DayAdvent<T> day) => Day = day;
        public abstract void Solve1();
        public abstract void Solve2();
    }
}
