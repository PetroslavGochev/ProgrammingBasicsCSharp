using System;

namespace _7.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForMeterSeconds = double.Parse(Console.ReadLine());
            //Calculation
            double distanceInSeconds = distanceInMeters * timeForMeterSeconds;
            double slowdown = Math.Floor(distanceInMeters / 15) * 12.5;
            
            double totalTime = distanceInSeconds + slowdown;
            if(recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
