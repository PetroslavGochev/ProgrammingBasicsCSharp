using System;

namespace _5.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {   //Input
            string products = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //Calculation
            if (city == "Sofia")
            {
                if (products == "coffee")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (products == "water")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (products == "beer")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (products == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (products == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (city == "Plovdiv")
            {
                if (products == "coffee")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else if (products == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (products == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (products == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (products == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            else if (city == "Varna")
            {
                if (products == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (products == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (products == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (products == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (products == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
            

        }
    }
}
