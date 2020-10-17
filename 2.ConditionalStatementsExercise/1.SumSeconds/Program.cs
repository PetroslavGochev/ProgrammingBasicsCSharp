using System;

namespace _1.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsFirst = int.Parse(Console.ReadLine());
            int secondsSecond = int.Parse(Console.ReadLine());
            int secondsThird = int.Parse(Console.ReadLine());

            var totalTime = secondsFirst + secondsSecond + secondsThird;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}
