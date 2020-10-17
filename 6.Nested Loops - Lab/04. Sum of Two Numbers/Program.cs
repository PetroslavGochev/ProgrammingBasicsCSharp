using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            bool indicator = false;
            int numberOfCombination = 0;


            for(int i = firstNumber; i <= secondNumber;i ++)
            {
                for(int second = firstNumber; second <= secondNumber; second++)
                {
                    numberOfCombination++;
                    if(i + second == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{numberOfCombination} ({i} + {second} = {magicalNumber})");
                        indicator = true;
                        break;
                    }
                }
                if (indicator)
                {
                    break;
                }
            }
            if (!indicator)
            {
                Console.WriteLine($"{numberOfCombination} combinations - neither equals {magicalNumber}");
            }

            
        }
    }
}
