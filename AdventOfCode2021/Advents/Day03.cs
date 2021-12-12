namespace AdventOfCode2021.Advents
{
    public class Day03 : DayAdvent<int>
    {
        public Day03(string filePath) : base(filePath)
        {
        }

        public override int Solve1()
        {
            var width = Lines[0].Length;
            int gammaRate = 0;
            for (int j = 0; j < width; j++)
            {
                int counter = 0;
                for (int i = 0; i < Lines.Length; i++)
                {
                    counter += Lines[i][j] - '0';
                }

                bool target = counter >= Lines.Length - counter;
                gammaRate |= Convert.ToInt16(target) << (width - j - 1);
            }

            int mask = (1 << width) - 1;
            int epsilonRate = ~gammaRate & mask;

            return gammaRate * epsilonRate;
        }

        public override int Solve2()
        {
            int oxygenRating = FindRating(new HashSet<string>(Lines), false);
            int coRating = FindRating(new HashSet<string>(Lines), true);

            return oxygenRating * coRating;
        }

        private int FindRating(HashSet<string> ratings, bool complement, int bit = 0)
        {
            if (ratings.Count == 1)
            {
                return Convert.ToInt32(ratings.First(), 2);
            }

            int counter = 0;
            foreach (var rating in ratings)
            {
                counter += rating[bit] - '0';
            }

            bool target = (counter >= ratings.Count - counter) ^ complement;
            ratings.RemoveWhere(rating =>
            {
                return (rating[bit] == '1') != target;
            });
            return FindRating(ratings, complement, bit + 1);
        }
    }
}
