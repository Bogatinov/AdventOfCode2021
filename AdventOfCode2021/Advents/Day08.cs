namespace AdventOfCode2021.Advents
{
    public class Day08 : DayAdvent<int>
    {
        public Day08(string filePath) : base(filePath)
        {
        }

        public override int Solve1()
        {
            int result = 0;

            foreach (var line in Lines)
            {
                foreach (var output in line.Split('|')[1].Split(' '))
                {
					if (output.Length == 2 || output.Length == 4 || output.Length == 3 || output.Length == 7)
					{
						result++;
					}
				}
            }

            return result;
        }

        public override int Solve2()
        {
            var lines = new List<(List<string> Signals, List<string> Outputs)>();
            foreach (var line in Lines)
            {
                var displays = line.Split(" | ");
                var tuple = (new List<string>(), new List<string>());
                var signals = displays[0].Split(' ');
                //sort them by length for switch-case
                //we need to map 1->7->4 first
                Array.Sort(signals, (a, b) => a.Length.CompareTo(b.Length));
                tuple.Item1.AddRange(signals);
                tuple.Item2.AddRange(displays[1].Split(' '));
                lines.Add(tuple);
            }

			int result = 0;
			foreach (var line in lines)
			{
				var mapping = new string[10];
				Array.Fill(mapping, string.Empty);

				foreach (var signal in line.Signals)
				{
					switch (signal.Length)
					{
						case 2:
							mapping[1] = signal;
							break;
						case 3:
							mapping[7] = signal;
							break;
						case 4:
							mapping[4] = signal;
							break;
						case 7:
							mapping[8] = signal;
							break;
						case 5:
							if (mapping[1].All(x => signal.Contains(x)))
							{
								mapping[3] = signal;
							}
							else if (mapping[4].Sum(x => Convert.ToInt16(signal.Contains(x))) == 3)
							{
								mapping[5] = signal;
							}
							else
							{
								mapping[2] = signal;
							}
							break;
						case 6:
							if (mapping[4].All(x => signal.Contains(x)))
							{
								mapping[9] = signal;
							}
							else if (mapping[7].All(x => signal.Contains(x)))
							{
								mapping[0] = signal;
							}
							else
							{
								mapping[6] = signal;
							}
							break;
					}
				}

				int number = 0;
				for (int i = 0; i < line.Outputs.Count; i++)
				{
					for (int j = 0; j < 10; j++)
					{
						var signal = mapping[j];
						var output = line.Outputs[i];

						var hasAllLetters = signal.All(x => output.Contains(x));
						if (signal.Length == output.Length && hasAllLetters)
						{
							number += j * (int)Math.Pow(10, line.Outputs.Count - i - 1);
							break;
						}
					}
				}

				result += number;
			}

			return result;
		}
    }
}
