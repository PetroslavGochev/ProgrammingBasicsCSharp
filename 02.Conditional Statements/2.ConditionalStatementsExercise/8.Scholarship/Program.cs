using System;

namespace _8.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double earningBgn = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalPay = double.Parse(Console.ReadLine());
            // Calculation
            double socialPrice = (minimalPay * 0.35);
            double excellentPrice = (averageSuccess * 25);
            if (earningBgn >= minimalPay)
            {
                if (averageSuccess >= 4.50 && averageSuccess < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (averageSuccess >= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentPrice)} BGN");
                }
            }
            else if (earningBgn < minimalPay)
            {
                if (averageSuccess>=4.50 && averageSuccess < 5.50)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialPrice)} BGN");
                }else if (averageSuccess < 4.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (averageSuccess >= 5.50)
                {
                    if (excellentPrice > socialPrice)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentPrice)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialPrice)} BGN");
                    }
                }
            }

        }
    }
}

