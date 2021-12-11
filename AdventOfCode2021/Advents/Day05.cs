using System.Numerics;

namespace AdventOfCode2021.Advents
{
    public class Day05 : DayAdvent<int>
    {
        private readonly Dictionary<Complex, int> _map;

        public Day05(string filePath) : base(filePath)
        {
            _map = new Dictionary<Complex, int>();
        }

        public override int Solve1()
        {
            foreach (var line in ReadLines())
            {
                if (line.Start.X == line.End.X || line.Start.Y == line.End.Y)
                {
                    SavePoints(line.Start, line.End);
                }
            }

            return CountIntersections();
        }

        public override int Solve2()
        {
            foreach (var line in ReadLines())
            {
                SavePoints(line.Start, line.End);
            }

            return CountIntersections();
        }

        IEnumerable<((int X, int Y) Start, (int X, int Y) End)> ReadLines()
        {
            foreach (var line in Lines)
            {
                var vectors = line.Split(" -> ");
                var vector1 = vectors[0].Split(",");
                var vector2 = vectors[1].Split(",");
                yield return ((int.Parse(vector1[0]), int.Parse(vector1[1])), (int.Parse(vector2[0]), int.Parse(vector2[1])));
            }
        }

        private void SavePoints((int X, int Y) start, (int X, int Y) end)
        {
            var norm = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
            Complex vector = new((end.X - start.X) / norm, (end.Y - start.Y) / norm);

            Complex point = new(start.X, start.Y);
            Complex endPoint = new(end.X, end.Y);

            while (true)
            {
                if (_map.ContainsKey(point) == false)
                {
                    _map[point] = 0;
                }

                _map[point]++;

                if (point == endPoint)
                    break;

                point += vector;
            }
        }

        private int CountIntersections()
        {
            var result = 0;
            foreach (var mapValue in _map.Values)
            {
                if (mapValue >= 2)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
