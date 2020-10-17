using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int stepSum = 0; ;
            int stepsPerDay = 10000;
            while (steps != "Going home")
            {
                stepSum += int.Parse(steps);
                if (stepSum >= stepsPerDay)
                {
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                stepSum += int.Parse(steps);
            }
            if (stepSum >= stepsPerDay)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepSum - stepsPerDay} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsPerDay - stepSum} more steps to reach goal.");
            }
        }
    }
}
