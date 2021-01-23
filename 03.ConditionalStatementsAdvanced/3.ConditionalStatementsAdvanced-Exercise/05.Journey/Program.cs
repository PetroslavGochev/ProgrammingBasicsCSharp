using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalPrice = 0.0;
            string destination = "";
            string place = "";
            if(budget <= 100 && season == "summer")
            {
                place = "Camp";
                totalPrice = budget * 0.30;
                destination = "Bulgaria";
            }
            else if (budget <=100 && season == "winter")
            {
                place = "Hotel";
                totalPrice = budget * 0.70;
                destination = "Bulgaria";
            }
            else if (budget <= 1000 && season == "summer")
            {
                place = "Camp";
                totalPrice = budget * 0.40;
                destination = "Balkans";
            }
            else if (budget<= 1000 && season == "winter")
            {
                place = "Hotel";
                totalPrice = budget * 0.80;
                destination = "Balkans";
            }
            else
            {
                place = "Hotel";
                totalPrice = budget * 0.9;
                destination = "Europe";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {totalPrice:f2}");
        }
    }
}
