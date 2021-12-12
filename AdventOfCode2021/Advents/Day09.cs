namespace AdventOfCode2021.Advents
{
    public class Day09 : DayAdvent<int>
    {
        private readonly int[][] matrix;

        public Day09(string filePath) : base(filePath)
        {
            matrix = new int[Lines.Length][];
            for (int i = 0; i < Lines.Length; i++)
            {
                var line = Lines[i];
                matrix[i] = new int[line.Length];
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i][j] = line[j] - '0';
                }
            }
        }

        public override int Solve1()
        {
            int result = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i > 0 && matrix[i - 1][j] <= matrix[i][j] ||
                        j > 0 && matrix[i][j - 1] <= matrix[i][j] ||
                        i < matrix.Length - 1 && matrix[i + 1][j] <= matrix[i][j] ||
                        j < matrix[i].Length - 1 && matrix[i][j + 1] <= matrix[i][j])
                    {
                        continue;
                    }

                    result += matrix[i][j] + 1;
                }
            }

            return result;
        }

        public override int Solve2()
        {
            var offsetX = new[] { -1, 0, 1, 0 };
            var offsetY = new[] { 0, 1, 0, -1 };
            var basins = new List<int>();
            var queue = new Queue<(int X, int Y)>();

            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    queue.Clear();
                    queue.Enqueue((x, y));

                    int size = 0;
                    while (queue.Count > 0)
                    {
                        var point = queue.Dequeue();
                        if (matrix[point.X][point.Y] == 9)
                        {
                            continue;
                        }

                        size++;
                        matrix[point.X][point.Y] = 9; //visited

                        for (int k = 0; k < 4; k++)
                        {
                            var endX = point.X + offsetX[k];
                            var endY = point.Y + offsetY[k];
                            if (endX >= 0 && endY >= 0 && endX < matrix.Length && endY < matrix[x].Length)
                            {
                                queue.Enqueue((endX, endY));
                            }
                        }
                    }

                    basins.Add(size);
                }
            }

            basins.Sort();
            return basins[^1] * basins[^2] * basins[^3];
        }
    }
}
