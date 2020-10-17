using System;

namespace _5.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinks =cakePrice-(cakePrice * 0.45);
            double animator = rent/3;
            double budget = rent + cakePrice + drinks + animator;

            Console.WriteLine(budget);
        }
    }
}
