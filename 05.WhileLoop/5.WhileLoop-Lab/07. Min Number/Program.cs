using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minxNumber = int.MaxValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                if (int.Parse(input) < minxNumber)
                {
                    minxNumber = int.Parse(input);
                }
            }
            Console.WriteLine(minxNumber);
        }
    }
}
