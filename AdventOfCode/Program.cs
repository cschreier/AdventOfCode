
namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numberOfDay = 0;
                bool isValidInput = false;
                while (!isValidInput)
                {
                    try
                    {
                        Console.Write("enter number of day to solve: ");
                        string inputDay = Console.ReadLine();
                        numberOfDay = Convert.ToInt32(inputDay);
                        isValidInput = true;
                    }
                    catch (Exception) { }
                }

                Solution solution = numberOfDay switch
                {
                    1 => new Day1(),
                    _ => null,
                };

                if (solution == null)
                {
                    Console.WriteLine("day not found");
                }
                else
                {
                    Console.WriteLine(solution.ToString());
                }

                Console.WriteLine("-------------------------");
            }
        }
    }
}