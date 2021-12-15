using System.Text;

namespace AdventOfCode2021.Advents
{
    public class Day13 : DayAdvent<string>
    {
        private readonly HashSet<Point> _coordinates;
        private readonly List<(char Direction, int Axis)> _steps;

        public Day13(string filePath) : base(filePath)
        {
            _coordinates = new();
            _steps = new();

            foreach (ReadOnlySpan<char> line in Lines)
            {
                if (line.IsWhiteSpace())
                {
                    continue;
                }

                if (line[0] == 'f')
                {
                    _steps.Add((line[11], int.Parse(line[13..])));
                }
                else
                {
                    var split = line.IndexOf(',');
                    int x = int.Parse(line[..split]);
                    int y = int.Parse(line[(split + 1)..]);
                    _coordinates.Add(new Point(x, y));
                }
            }
        }

        public override string Solve1()
        {
            var (direction, axis) = _steps[0];
            HashSet<Point> result = new(_coordinates.Count / 2);
            foreach (var point in _coordinates)
            {
                result.Add(point.MoveBy(direction, axis));
            }

            _coordinates.Clear();
            return result.Count.ToString();
        }

        public override string Solve2()
        {
            HashSet<Point> coordinates = new(_coordinates.Count / 2);
            foreach (var (direction, axis) in _steps)
            {
                foreach (var point in _coordinates)
                {
                    coordinates.Add(point.MoveBy(direction, axis));
                }

                _coordinates.Clear();
                _coordinates.UnionWith(coordinates);
                coordinates.Clear();
            }

            var (height, width) = FindMax();

            StringBuilder result = new();
            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                    if (_coordinates.Contains(new Point(j, i)))
                    {
                        result.Append('#');
                    }
                    else
                    {
                        result.Append('.');
                    }
                }
                result.AppendLine();
            }

            _coordinates.Clear();
            return result.ToString();
        }

        private (int Height, int Width) FindMax()
        {
            int height = 0;
            int width = 0;
            foreach (var point in _coordinates)
            {
                if (point.Y > height)
                {
                    height = point.Y;
                }

                if (point.X > width)
                {
                    width = point.X;
                }
            }

            return (height, width);
        }
    }

    public class Point : IEquatable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point MoveBy(char direction, int axis)
        {
            return direction == 'x' ? new Point(GetCoordinate(X, axis), Y) : new Point(X, GetCoordinate(Y, axis));
        }

        private static int GetCoordinate(int coordinate, int axis) => coordinate < axis ? coordinate : 2 * axis - coordinate;

        public int X;
        public int Y;

        public bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
