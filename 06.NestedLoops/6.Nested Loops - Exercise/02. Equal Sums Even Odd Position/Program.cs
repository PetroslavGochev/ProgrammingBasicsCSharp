using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNum = i.ToString();
                double sumEven = 0;
                double sumOdd = 0;
                for(int j = 0; j< currentNum.Length; j++)
                {
                    if(j%2 == 0)
                    {
                        sumEven += int.Parse(currentNum[j].ToString());
                    }
                    else
                    {
                        sumOdd += int.Parse(currentNum[j].ToString());
                    }
                }
                if(sumOdd == sumEven)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
