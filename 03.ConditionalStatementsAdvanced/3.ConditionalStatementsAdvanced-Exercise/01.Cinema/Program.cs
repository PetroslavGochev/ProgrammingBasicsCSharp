using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalPeople = rows * columns;
            switch (projection)
            {
                case "Premiere":
                    Console.WriteLine($"{totalPeople * 12.00:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{totalPeople * 7.50:f2} leva");
                    break;
                default:
                    Console.WriteLine($"{totalPeople * 5.00:f2} leva");
                    break;
            }
        }
    }
}
