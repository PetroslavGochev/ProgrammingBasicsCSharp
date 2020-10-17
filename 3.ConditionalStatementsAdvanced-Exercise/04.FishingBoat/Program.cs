using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetsOfGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            if (season == "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
                if (numberOfFishermen <= 6)
                {
                    totalPrice = totalPrice * 0.9;
                }
                else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else
                {
                    totalPrice = totalPrice * 0.75;
                }
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
                if (numberOfFishermen <= 6)
                {
                    totalPrice = totalPrice * 0.9;
                }
                else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else
                {
                    totalPrice = totalPrice * 0.75;
                }
            }
            else
            {
                totalPrice = 3000;
                if (numberOfFishermen <= 6)
                {
                    totalPrice = totalPrice * 0.9;
                }
                else if (numberOfFishermen > 7 && numberOfFishermen <= 11)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else
                {
                    totalPrice = totalPrice * 0.75;
                }
            }
            if(numberOfFishermen % 2 == 0 && season != "Autumn") 
            {
                totalPrice = totalPrice * 0.95;
            }
            if(totalPrice > budgetsOfGroup)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budgetsOfGroup:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budgetsOfGroup - totalPrice:f2} leva left.");
            }
        }
    }
}