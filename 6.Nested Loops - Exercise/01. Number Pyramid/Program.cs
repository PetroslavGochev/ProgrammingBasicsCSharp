using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            bool bigger = false;

            for(int row = 1; row<= number; row++)
            {
                for(int columns = 1; columns <= row; columns++)
                {
                    if(currentNumber > number)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write($"{currentNumber} ");
                    currentNumber++;

                }
                if (bigger == true)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
