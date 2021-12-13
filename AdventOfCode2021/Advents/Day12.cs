namespace AdventOfCode2021.Advents
{
    public class Day12 : DayAdvent<int>
    {
        private readonly Graph _graph;

        public Day12(string filePath) : base(filePath)
        {
            _graph = new(Lines);
        }

        public override int Solve1()
        {
            return _graph.Visit(false);
        }

        public override int Solve2()
        {
            return _graph.Visit(true);
        }
    }

    public class Graph
    {
        private readonly int _start;
        private readonly int _end;
        private readonly List<List<int>> _edges;
        private readonly List<bool> _isUpper;

        public Graph(string[] lines)
        {
            var map = new Dictionary<string, int>();

            _edges = new(12);
            foreach (var line in lines)
            {
                var vertice = line.Split('-');
                BuildIndex(vertice[0]);
                BuildIndex(vertice[1]);
                TryAdd(vertice[0], vertice[1]);
                TryAdd(vertice[1], vertice[0]);
            }

            _start = map["start"];
            _end = map["end"];

            _isUpper = new(map.Count);
            foreach (var key in map.Keys)
            {
                _isUpper.Add(char.IsUpper(key[0]));
            }

            void BuildIndex(string vertice)
            {
                if (!map.ContainsKey(vertice))
                {
                    map.Add(vertice, map.Count);
                }
            }

            void TryAdd(string from, string to)
            {
                if (_edges.Count <= map[from])
                {
                    _edges.Add(new List<int>());
                }
                _edges[map[from]].Add(map[to]);
            }
        }

        public int Visit(bool multipleTimes)
        {
            int result = 0;

            var visits = new Stack<(int, int, bool)>();
            visits.Push((_start, 1 << _start, !multipleTimes));

            while (visits.Count > 0)
            {
                var (parent, count, duplicate) = visits.Pop();

                foreach (int edge in _edges[parent])
                {
                    if (IsEnd(edge))
                    {
                        result++;
                        continue;
                    }

                    if (MultipleTimes(edge, count))
                    {
                        visits.Push((edge, count | 1 << edge, duplicate));
                    }
                    else if (OnlyOnce(edge, duplicate))
                    {
                        visits.Push((edge, count, true));
                    }
                }
            }

            return result;

            bool IsEnd(int edge) => edge == _end;

            bool MultipleTimes(int edge, int count) => _isUpper[edge] || (count >> edge & 1) == 0;

            bool OnlyOnce(int edge, bool duplicate) => edge != _start && !duplicate;
        }
    }
}