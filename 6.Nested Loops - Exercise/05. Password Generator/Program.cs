using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string letter = "abcdefghi";

            for(int firstNumber = 1; firstNumber < n; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber < n; secondNumber++)
                {
                    for (char firstLetter = 'a'; firstLetter < letter[l]; firstLetter++)
                    {
                        for (char secondLetter = 'a'; secondLetter < letter[l]; secondLetter++)
                        {
                            for(int lastNumber = 1; lastNumber <= n; lastNumber++)
                            {
                                if (lastNumber > firstNumber && lastNumber > secondNumber)
                                {
                                    Console.Write($"{firstNumber}{secondNumber}{firstLetter}{secondLetter}{lastNumber} ");
                                }                               
                            }
                        }
                    }
                }
            }
        }
    }
}
