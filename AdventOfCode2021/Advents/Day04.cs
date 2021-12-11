namespace AdventOfCode2021.Advents
{
    public class Day04 : DayAdvent<int>
    {
		private readonly List<int> _bingo;
		private readonly List<Card> _bingoCards;

		public Day04(string filePath) : base(filePath)
        {
            _bingo = new(27);
            foreach (string bingo in Lines[0].Split(","))
            {
                this._bingo.Add(int.Parse(bingo));
            }

			_bingoCards = new(Lines.Length - 1);
			var matrix = new Card(5);
			for (int i = 2; i < Lines.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(Lines[i]))
				{
					_bingoCards.Add(matrix);
					matrix = new Card(5);
					continue;
				}

				matrix.AddRow(Lines[i]);
			}

			_bingoCards.Add(matrix);
		}

        public override int Solve1()
        {
			foreach (var number in _bingo)
			{
				foreach (var matrix in _bingoCards)
				{
					matrix.Visit(number);
					if (matrix.Bingo)
					{
						return number * matrix.Sum;
					}
				}
			}

			return 0;
		}

        public override int Solve2()
        {
			var result = new Stack<int>(_bingoCards.Count);
			foreach (var number in _bingo)
			{
				foreach (var matrix in _bingoCards)
				{
					if (matrix.Bingo)
					{
						continue; //skip them since they won
					}

					matrix.Visit(number);
					if (matrix.Bingo)
					{
						result.Push(number * matrix.Sum);
					}
				}
			}

			return result.Peek();
		}
    }

	public class Card
	{
		private readonly int _size;
		private readonly List<Number> _nodes;

		public Card(int size)
		{
			Bingo = false;
			_size = size;

			Sum = 0;
			_nodes = new List<Number>(size * size);
		}

		public bool Bingo { get; private set; }
		public int Sum { get; private set; }

		public void AddRow(string line)
		{
			var row = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			foreach (var value in row)
			{
				var node = new Number(value);
				Sum += node.Value;
				_nodes.Add(node);
			}
		}

		public void Visit(int value)
		{
			foreach (var node in _nodes)
			{
				if (node.Visit(value))
				{
					Sum -= node.Value;
				}
			}

			Bingo = Wins();
		}

		private bool Wins()
		{
			int counter;
			for (int i = 0; i < _size; i++)
			{
				counter = 0;
				for (int j = 0; j < _size; j++)
				{
					if (_nodes[j + _size * i].Visited)
					{
						counter++;
					}
				}

				if (counter == _size)
				{
					return true;
				}
			}

			counter = 0;
			for (int i = 0; i < _size; i++)
			{
				counter = 0;
				for (int j = 0; j < _size; j++)
				{
					if (_nodes[i + _size * j].Visited)
					{
						counter++;
					}

				}
				if (counter == _size)
				{
					return true;
				}
			}
			return false;
		}
	}

	public class Number
	{
		public Number(string value)
		{
			Visited = false;
			Value = int.Parse(value);
		}

		public int Value { get; }
		public bool Visited { get; private set; }

		public bool Visit(int value)
		{
			if (value != Value)
				return false;

			Visited = true;
			return true;
		}
	}
}
