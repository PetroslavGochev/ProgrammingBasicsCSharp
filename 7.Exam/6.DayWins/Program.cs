using System;

namespace _6.DayWins
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRow = int.Parse(Console.ReadLine());
            int numberOfPosition = int.Parse(Console.ReadLine());
            int strawberry = 0;
            int raspberry = 0;

            for (int row = 1; row <= numberOfRow; row++)
            {
                for (int position = 1; position <= numberOfPosition; position++)
                {
                    if (row % 2 != 0)
                    {
                        strawberry++;
                    }
                    else if (row % 2 == 0 && position % 3 != 0)
                    {
                        raspberry++;
                    }
                }
            }
            double totalSum = (strawberry * 3.50 + raspberry * 5.00) * 0.8;

            Console.WriteLine($"Total: {totalSum:f2} lv.");
        }
    }
}
