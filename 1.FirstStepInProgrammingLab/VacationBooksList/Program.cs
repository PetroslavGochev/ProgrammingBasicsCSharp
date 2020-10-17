using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double result = (allPages / pages) / days;
            Console.WriteLine(result);
        }
    }
}
