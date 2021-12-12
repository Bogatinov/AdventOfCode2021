namespace AdventOfCode2021.Advents
{
    public class Day10 : DayAdvent<long>
    {
        private readonly Dictionary<char, char> _pairs;

        public Day10(string filePath) : base(filePath)
        {
            _pairs = new()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' },
                { '>', '<' }
            };
        }

        public override long Solve1()
        {
            long result = 0;

            foreach (var line in Lines)
            {
                var stack = new Stack<char>();
                foreach (var bracket in line)
                {
                    if (bracket is '{' or '[' or '<' or '(')
                    {
                        stack.Push(bracket);
                    }
                    else if (stack.Peek() == _pairs[bracket])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        result += bracket switch
                        {
                            ')' => 3,
                            ']' => 57,
                            '}' => 1197,
                            '>' => 25137,
                            _ => throw new ArgumentOutOfRangeException()
                        };
                        break;
                    }
                }
            }

            return result;
        }

        public override long Solve2()
        {
            var scores = new List<long>();

            foreach (var line in Lines)
            {
                var stack = new Stack<char>();
                int i;
                for (i = 0; i < line.Length; i++)
                {
                    var bracket = line[i];
                    if (bracket is '{' or '[' or '<' or '(')
                    {
                        stack.Push(bracket);
                    }
                    else if (stack.Peek() == _pairs[bracket])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                if (i == line.Length)
                {
                    long score = 0;
                    foreach (var tag in stack)
                    {
                        score = score * 5 + tag switch
                        {
                            '(' => 1,
                            '[' => 2,
                            '{' => 3,
                            '<' => 4,
                            _ => throw new ArgumentOutOfRangeException()
                        };
                    }
                    scores.Add(score);
                }

            }

            scores.Sort();
            return scores[(scores.Count - 1) / 2];
        }
    }
}
