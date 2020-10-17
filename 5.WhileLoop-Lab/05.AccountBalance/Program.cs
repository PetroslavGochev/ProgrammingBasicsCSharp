using System;
using System.Xml.Schema;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double total = 0.0;
            while((input = Console.ReadLine()) != "NoMoreMoney")
            {
                if(double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {double.Parse(input):f2}");
                total += double.Parse(input);
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
