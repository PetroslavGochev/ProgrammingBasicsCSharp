using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());
            int exerciseStart = (hours * 60) + minutes;
            int studentsArrivals = (hoursArrival * 60) + minutesArrival;
            int minutesDifference = Math.Abs(exerciseStart - studentsArrivals);
            int totalHours = minutesDifference / 60;
            int totalMinutes = minutesDifference % 60;

            if (studentsArrivals > exerciseStart)
            {
                if (minutesDifference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
                else 
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{totalHours}:{totalMinutes:d2} hours after the start");
                }
            }
            else if (minutesDifference > 30 && studentsArrivals < exerciseStart)
            {
                if (minutesDifference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{totalHours}:{totalMinutes:d2} hours before the start");
                }
            }
            else
            {
                if (studentsArrivals == exerciseStart)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
            }

        }
    }
}
