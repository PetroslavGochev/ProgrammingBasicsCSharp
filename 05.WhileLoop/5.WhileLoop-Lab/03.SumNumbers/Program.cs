using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += numberTwo;

            while (sum < number)
            {
                numberTwo = int.Parse(Console.ReadLine());
                sum += numberTwo;
            }
            Console.WriteLine(sum);

        }
    }
}
