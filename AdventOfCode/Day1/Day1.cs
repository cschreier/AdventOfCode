namespace AdventOfCode
{
    public class Day1 : Solution
    {
        private readonly IEnumerable<int> _caloriesPerElf;

        public override int ResultPuzzle1 => _caloriesPerElf.Max();
        public override int ResultPuzzle2 => _caloriesPerElf.OrderByDescending(c => c).Take(3).Sum();

        public Day1()
        {
            string[] input = File.ReadAllText(Path.Combine("Day1", "input.txt")).Split("\r\n\r\n");
            _caloriesPerElf = input.Select(c => c.Split("\r\n").Select(x => Convert.ToInt32(x)).Sum());
        }

        public override string ToString()
        {
            return $"puzzle 1: {ResultPuzzle1} | puzzle 2: {ResultPuzzle2}";
        }
    }
}
