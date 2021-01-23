using System;

namespace _03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumEven = 0.0;
            double sumOdd = 0.0;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }
                }
                else
                {
                    sumOdd += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            } 
            else if (maxEven == double.MinValue)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }


        }
    }
}
