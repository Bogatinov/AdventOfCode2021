using System.Text;

namespace AdventOfCode2021.Advents
{
    public class Day13 : DayAdvent<string>
    {
        private HashSet<(int X, int Y)> _coordinates;
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
                    _coordinates.Add((x, y));
                }
            }
        }

        public override string Solve1()
        {
            var (direction, axis) = _steps[0];

            return Fold(direction, axis).Count.ToString();
        }

        public override string Solve2()
        {
            foreach (var (direction, axis) in _steps)
            {
                _coordinates = Fold(direction, axis);
            }

            var (height, width) = FindMax();

            StringBuilder result = new();
            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                    if (_coordinates.Contains((j, i)))
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

            return result.ToString();
        }

        private (int Height, int Width) FindMax()
        {
            int height = 0;
            int width = 0;
            foreach (var (x, y) in _coordinates)
            {
                if (y > height)
                {
                    height = y;
                }

                if (x > width)
                {
                    width = x;
                }
            }

            return (height, width);
        }

        private HashSet<(int, int)> Fold(char direction, int axis)
        {
            HashSet<(int, int)> result = new();

            if (direction == 'x')
            {
                foreach (var (x, y) in _coordinates)
                {
                    result.Add((NewCoordinate(x, axis), y));
                }
            }
            else
            {
                foreach (var (x, y) in _coordinates)
                {
                    result.Add((x, NewCoordinate(y, axis)));
                }
            }

            return result;
        }

        private static int NewCoordinate(int coordinate, int axis) => coordinate < axis ? coordinate : 2 * axis - coordinate;
    }
}
