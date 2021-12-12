using AdventOfCode2021.Advents;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public abstract class DayAdventFixture<T>
    {
        private readonly DayAdvent<T> _day;

        public DayAdventFixture(DayAdvent<T> day) => _day = day;

        [Fact]
        public void Solve1()
        {
            var result = _day.Solve1();

            Assert.Equal(Expected1, result);
        }

        [Fact]
        public void Solve2()
        {
            var result = _day.Solve2();

            Assert.Equal(Expected2, result);
        }

        protected abstract T Expected1 { get; }
        protected abstract T Expected2 { get; }

    }
}
