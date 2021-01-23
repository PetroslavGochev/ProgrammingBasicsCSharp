using System;

namespace _7.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {   //Input
            double priceOfVacantion = double.Parse(Console.ReadLine());
            double numberOfPuzzles = double.Parse(Console.ReadLine());
            double talkingDoll = double.Parse(Console.ReadLine());
            double teddyBear = double.Parse(Console.ReadLine());
            double minion = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());
            //Calculation
            double sum = (numberOfPuzzles * 2.6) + (talkingDoll * 3) + (teddyBear * 4.1) + (minion * 8.2) + (trucks * 2);
            double numberOfToy = numberOfPuzzles + talkingDoll + teddyBear + minion + trucks;
            if (numberOfToy >= 50)
            {
                double discount = sum * 0.25;
                double endPrice = sum - discount;
                double rent = endPrice * 0.1;
                double profit = endPrice - rent;
                if (profit >= priceOfVacantion)
                {
                    Console.WriteLine($"Yes! {profit - priceOfVacantion:f2} lv left.");
                }
                else
                    Console.WriteLine($"Not enough money! {priceOfVacantion - profit:f2} lv needed.");
            }
            else if (numberOfToy < 50)
            {
                double rent = sum * 0.1;
                double profit = sum - rent;
                if (profit >= priceOfVacantion)
                {
                    Console.WriteLine($"Yes! {profit - priceOfVacantion:f2} lv left.");
                }
                else
                    Console.WriteLine($"Not enough money! {priceOfVacantion - profit:f2} lv needed.");
            }
        }
    }
}
