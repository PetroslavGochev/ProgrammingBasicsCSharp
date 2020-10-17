using System;

namespace _03._Kart_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrySum = double.Parse(Console.ReadLine());
            string lap = Console.ReadLine();
            string fanCard = Console.ReadLine();
            string typeOfCard = Console.ReadLine();
            double totalSum = 0.0;

            if(lap == "five")
            {
                if(typeOfCard == "Child")
                {
                    totalSum += 7;
                }
                else if (typeOfCard == "Junior")
                {
                    totalSum += 9;
                }
                else if (typeOfCard == "Adult")
                {
                    totalSum += 12;
                }
                else
                {
                    totalSum += 18;
                }
            }
            else
            {
                if (typeOfCard == "Child")
                {
                    totalSum += 11;
                }
                else if (typeOfCard == "Junior")
                {
                    totalSum += 16;
                }
                else if (typeOfCard == "Adult")
                {
                    totalSum += 21;
                }
                else
                {
                    totalSum += 32;
                }
            }
            if (fanCard == "yes")
            {
                totalSum *= 0.80;
            }
            if(totalSum <= entrySum)
            {
                Console.WriteLine($"You bought {typeOfCard} ticket for {lap} laps. Your change is {entrySum - totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need {totalSum - entrySum:f2}lv more.");
            }
        }
    }
}
