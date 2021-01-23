using System;

namespace _04._Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numberOfMonth = int.Parse(Console.ReadLine());
            double sumForSimple = money;
            double sumForComplex = money;
            

            for(int month = 1; month<= numberOfMonth; month++)
            {
                sumForSimple += money * 3 / 100;
                sumForComplex += sumForComplex * 2.7/ 100;
            }
            Console.WriteLine($"Simple interest rate: {sumForSimple:f2} lv.");
            Console.WriteLine($"Complex interest rate: {sumForComplex:f2} lv.");

            if(sumForSimple > sumForComplex)
            {
                Console.WriteLine($"Choose a simple interest rate. You will win {sumForSimple - sumForComplex:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Choose a complex interest rate. You will win {sumForComplex - sumForSimple:f2} lv.");
            }
        }
    }
}
