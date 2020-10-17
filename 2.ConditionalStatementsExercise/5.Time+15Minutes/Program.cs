using System;

namespace _5.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = hours * 60 + minutes;
            int newHours = ((15 + totalMinutes) / 60);
            int newMinutes = ((15 + totalMinutes) % 60);
            if (newHours >= 24)
            {
                int hoursNew = 24 - newHours;
                Console.WriteLine($"{hoursNew}:{newMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes:D2}");
            }


        }
    }
}

