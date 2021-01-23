using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int day = 1;
            int startMeters = 5364;

            while((text = Console.ReadLine())!= "END")
            {
                int numberOfMeters = int.Parse(Console.ReadLine());
                if(text == "Yes")
                {
                    day++;
                }
                if(day > 5)
                {
                    Console.WriteLine($"Failed!");
                    Console.WriteLine($"{startMeters}");
                    break;
                }
                startMeters += numberOfMeters;
                if(startMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {day} days!");
                    break;
                }
            }
            if (text == "END")
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{startMeters}");
            }
        }
    }
}
