using System;

namespace _6.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {   //Input
            double budgetMovie = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double priceForOneExtras = double.Parse(Console.ReadLine());
            //Calculation
            double sumForDecor = budgetMovie * 0.1;
            double priceForClothes = numberOfExtras * priceForOneExtras;
            double totalSumForMovie = 0.0;
           
            if (numberOfExtras >= 150)
            {
                double discountExtras = priceForClothes * 0.9;
                totalSumForMovie = sumForDecor + discountExtras;
            }else
            {
                totalSumForMovie = sumForDecor + priceForClothes;
            }
           if(totalSumForMovie<= budgetMovie)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetMovie - totalSumForMovie:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSumForMovie - budgetMovie:f2} leva more.");
            }

        }
    }
}
