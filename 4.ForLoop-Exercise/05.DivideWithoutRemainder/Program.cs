using System;
using System.Security.Cryptography;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            for (int i = 1; i <=n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                {
                    p1++;
                }
                if(number % 3 == 0)
                {
                    p2++;
                }
                if(number % 4 == 0)
                {
                    p3++;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
