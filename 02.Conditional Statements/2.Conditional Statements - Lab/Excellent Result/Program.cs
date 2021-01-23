using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine());
            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
