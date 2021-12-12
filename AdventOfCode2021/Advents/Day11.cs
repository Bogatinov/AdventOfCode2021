namespace AdventOfCode2021.Advents
{
    public class Day11 : DayAdvent<int>
    {
        private readonly List<int> _octopuses;

        public Day11(string filePath) : base(filePath)
        {
            _octopuses = new(100);
            foreach (var line in Lines)
            {
                foreach (var octopus in line)
                {
                    _octopuses.Add(octopus - '0');
                }
            }
        }

        public override int Solve1()
        {
            int result = 0;

            Queue<int> queue = new();

            for (int i = 0; i < 100; i++)
            {
                result += Step(queue);
            }

            return result;
        }

        public override int Solve2()
        {
            int result = 1;
            Queue<int> queue = new();

            while (Step(queue) != _octopuses.Count)
                result++;

            return result;
        }

        private int Step(Queue<int> queue)
        {
            int result = 0;

            queue.Clear();

            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    int index = j + 10 * k;
                    if (_octopuses[index]++ >= 9)
                    {
                        queue.Enqueue(index);
                    }
                }
            }

            while (queue.Count > 0)
            {
                var index = queue.Dequeue();
                if (_octopuses[index] <= 9)
                {
                    continue;
                }

                _octopuses[index] = 0;

                result++;

                int x = index % 10;
                int y = index / 10;
                for (int dx = x - 1; dx <= x + 1; dx++)
                {
                    for (int dy = y - 1; dy <= y + 1; dy++)
                    {
                        if (dx is < 0 or >= 10 || dy is < 0 or >= 10 || (dx == x && dy == y))
                        {
                            continue;
                        }

                        int dIndex = dx + 10 * dy;
                        if (_octopuses[dIndex] != 0 && _octopuses[dIndex]++ >= 9)
                        {
                            queue.Enqueue(dIndex);
                        }
                    }
                }
            }

            return result;
        }
    }
}
