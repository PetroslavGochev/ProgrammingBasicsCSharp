using System;

namespace _09.LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 0; i< n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                leftsum =leftsum +  number1;
            }
            for (int i = 0; i<n; i ++)
            {
                int number3 = int.Parse(Console.ReadLine());
                rightsum = rightsum + number3;
            }
            if (leftsum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftsum - rightsum)}");
            }
        }
    }
}
