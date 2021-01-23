using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budgets = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (typeOfFlowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    price = (numberOfFlowers * 5.00) * 0.9;
                }
                else
                {
                    price = numberOfFlowers * 5.00;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    price = numberOfFlowers * 3.80 * 0.85;
                }
                else
                {
                    price = numberOfFlowers * 3.80;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    price = numberOfFlowers * 2.80 * 0.85;
                }
                else 
                {
                    price = numberOfFlowers * 2.80;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numberOfFlowers < 120 )
                {

                    price = numberOfFlowers * 3 * 0.15 + (numberOfFlowers * 3);
                }
                else
                {
                    price = numberOfFlowers * 3;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    price = numberOfFlowers * 2.50 * 0.20 + (numberOfFlowers * 2.50);
                }
                else
                {
                    price = numberOfFlowers * 2.50;
                }
            }
            if (budgets < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budgets:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {budgets - price:f2} leva left.");
            }
        }
    }
}
