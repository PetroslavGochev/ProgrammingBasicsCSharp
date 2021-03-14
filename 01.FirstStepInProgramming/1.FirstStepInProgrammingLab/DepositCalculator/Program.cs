using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double number = double.Parse(Console.ReadLine());
            double yearsPercent = number / 100;
            Console.WriteLine(deposit+month*((deposit*yearsPercent)/12));
        }
    }
}
