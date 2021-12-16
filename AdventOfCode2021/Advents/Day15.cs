namespace AdventOfCode2021.Advents
{
    public class Day15 : DayAdvent<int>
    {
        private readonly List<int> _map;
        private readonly int _size;

        private readonly int[] _dx;
        private readonly int[] _dy;

        public Day15(string filePath) : base(filePath)
        {
            _map = new List<int>(Lines.Length * Lines.Length);
            foreach (var line in Lines)
            {
                foreach (var value in line)
                {
                    _map.Add(value - '0');
                }
            }

            _size = Lines.Length;

            _dx = new int[4] { 0, 0, -1, 1 };
            _dy = new int[4] { -1, 1, 0, 0 };
        }

        public override int Solve1() => Solve(1);

        public override int Solve2() => Solve(5);

        private int Solve(int scale)
        {
            PriorityQueue<Point, int> queue = new();
            queue.Enqueue(new Point(0, 0), 0);

            var result = new int[_map.Count * scale * scale];
            Array.Fill(result, int.MaxValue);
            result[0] = 0;

            int scaleSize = _size * scale;
            while (queue.Count > 0)
            {
                var point = queue.Dequeue();
                int dx = point.Index % scaleSize;
                int dy = point.Index / scaleSize;

                for (int i = 0; i < 4; i++)
                {
                    int x = dx + _dx[i];
                    int y = dy + _dy[i];
                    if (y < 0 || y >= scaleSize || x < 0 || x >= scaleSize)
                    {
                        continue;
                    }

                    int value = _map[y % _size * _size + x % _size] + x / _size + y / _size;
                    if (value > 9)
                    {
                        value -= 9;
                    }

                    int pathDistance = point.Distance + value;
                    int index = x + y * scaleSize;
                    if (pathDistance < result[index])
                    {
                        result[index] = pathDistance;
                        queue.Enqueue(new Point(pathDistance, index), pathDistance);
                    }
                }
            }

            return result[^1];
        }

        public struct Point : IEquatable<Point>
        {
            public Point(int distance, int index)
            {
                Distance = distance;
                Index = index;
            }

            public int Distance;
            public int Index;

            public bool Equals(Point other)
            {
                return Index == other.Index;
            }

            public override int GetHashCode()
            {
                return Index.GetHashCode();
            }
        }
    }
}
