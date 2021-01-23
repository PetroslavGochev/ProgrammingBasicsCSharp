using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForVacantion = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = daysForVacantion - 1;
            if (roomType == "apartment")
            {
                if (nights < 10)
                {
                    double price = nights * 25.00;
                    double priceDisc = price * 0.70;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
                else if (10 <= nights && nights <= 15)
                {
                    double price = nights * 25.00;
                    double priceDisc = price * 0.65;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
                else
                {
                    double price = nights * 25.00;
                    double priceDisc = price * 0.50;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
            }
            else if (roomType == "president apartment")
            {
                if (nights < 10)
                {
                    double price = nights * 35.00;
                    double priceDisc = price * 0.90;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
                else if (10 <= nights && nights <= 15)
                {
                    double price = nights * 35.00;
                    double priceDisc = price * 0.85;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
                else
                {
                    double price = nights * 35.00;
                    double priceDisc = price * 0.80;
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{priceDisc + (priceDisc * 25 / 100):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceDisc * 0.9:f2}");
                    }
                }
            }
            else
            {
                double price = nights * 18.00;
                if (rating == "positive")
                {
                    Console.WriteLine($"{price + (price * 25 / 100):f2}");
                }
                else
                {
                    Console.WriteLine($"{price * 0.9:f2}");
                }

            }
        }
    }
}

