using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposite = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double number = double.Parse(Console.ReadLine());
            double yearsPercent = number / 100;
            Console.WriteLine(deposite+month*((deposite*yearsPercent)/12));
        }
    }
}
