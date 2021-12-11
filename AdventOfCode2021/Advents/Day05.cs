namespace AdventOfCode2021.Advents
{
    public class Day05 : DayAdvent<int>
    {
        private readonly Dictionary<(int, int), int> _map;

        public Day05(string filePath) : base(filePath)
        {
            _map = new();
        }

        public override int Solve1()
        {
            foreach (var line in Lines)
            {
                var vector = Parse(line);
                if (vector.X1 == vector.X2 || vector.Y1 == vector.Y2)
                {
                    SavePoints(vector);
                }
            }

            return CountIntersections();
        }

        public override int Solve2()
        {
            foreach (var line in Lines)
            {
                SavePoints(Parse(line));
            }

            return CountIntersections();
        }

        (int X1, int Y1, int X2, int Y2) Parse(ReadOnlySpan<char> line)
        {
            var pointsIndex = line.IndexOf(" -> ");
            var point1 = line.Slice(0, pointsIndex);
            var coordinateIndex1 = point1.IndexOf(',');
            var point2 = line.Slice(pointsIndex + 3);
            var coordinateIndex2 = point2.IndexOf(',');

            return (
                int.Parse(point1.Slice(0, coordinateIndex1)), int.Parse(point1.Slice(coordinateIndex1 + 1)),
                int.Parse(point2.Slice(0, coordinateIndex2)), int.Parse(point2.Slice(coordinateIndex2 + 1))
                );
        }

        private void SavePoints((int X1, int Y1, int X2, int Y2) line)
        {
            var stepX = GetStep(line.X1, line.X2);
            var stepY = GetStep(line.Y1, line.Y2);

            var endX = GetEnd(line.X2, stepX);
            var endY = GetEnd(line.Y2, stepY);

            for (int x = line.X1, y = line.Y1; x != endX && y != endY; x += stepX, y += stepY)
            {
                var coordinate = (x, y);
                _map.TryGetValue(coordinate, out var intersection);
                _map[coordinate] = intersection + 1;
            }

            int GetStep(int point1, int point2)
            {
                return point1 == point2 ? 0 : (point1 < point2 ? 1 : -1);
            }

            int GetEnd(int point2, int stepPoint)
            {
                return point2 + (stepPoint == 0 ? 1 : stepPoint);
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
