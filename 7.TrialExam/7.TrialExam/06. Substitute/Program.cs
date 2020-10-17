using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfFirstNumber = int.Parse(Console.ReadLine());
            int startOfSecondFirstNumber = int.Parse(Console.ReadLine());
            int startOfSeconNumber = int.Parse(Console.ReadLine());
            int startOfSecondSecondNumber = int.Parse(Console.ReadLine());
            int change = 0;

            for (int first = startOfFirstNumber; first<= 8; first++)
            {
                if(first % 2 != 0)
                {
                    continue;
                }
                for(int second = 9; second >= startOfSecondFirstNumber; second--)
                {
                    if(second % 2 == 0)
                    {
                        continue;
                    }
                    for(int firstSecondNumber = startOfSeconNumber; firstSecondNumber <= 8; firstSecondNumber++)
                    {
                        if(firstSecondNumber % 2 != 0)
                        {
                            continue;
                        }
                        for(int secondSeconNumber = 9; secondSeconNumber >= startOfSecondSecondNumber; secondSeconNumber--)
                        {
                            if(secondSeconNumber % 2 == 0)
                            {
                                continue;
                            }
                            if(first == firstSecondNumber && second == secondSeconNumber)
                            {
                                Console.WriteLine($"Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{first}{second} - {firstSecondNumber}{secondSeconNumber}");
                                change++;
                        }
                            if(change == 6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
