using AdventOfCode2021.Advents;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2021.Benchmarks
{
    [MemoryDiagnoser]
    public abstract class DayAdventBenchmark<T>
    {
        protected DayAdvent<T> Day;

        [GlobalSetup]
        public abstract void Setup();

        [Benchmark]
        public T Solve1() => Day.Solve1();

        [Benchmark]
        public T Solve2() => Day.Solve2();
    }
}
