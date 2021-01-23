using System;

namespace _04._Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int allNumber = 1;

            while(allNumber <= number)
            {
                Console.WriteLine(allNumber);
                allNumber = allNumber * 2 + 1;
            }
        }
    }
}
