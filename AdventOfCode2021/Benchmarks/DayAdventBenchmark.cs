using AdventOfCode2021.Advents;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2021.Benchmarks
{
    [MemoryDiagnoser]
    public abstract class DayAdventBenchmark<T>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected DayAdvent<T> Day;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [GlobalSetup]
        public abstract void Setup();

        [Benchmark]
        public T Solve1() => Day.Solve1();

        [Benchmark]
        public T Solve2() => Day.Solve2();
    }
}
