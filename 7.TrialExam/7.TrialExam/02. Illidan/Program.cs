using System;

namespace _02._Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int powerOfOnePersonInGroup = int.Parse(Console.ReadLine());
            int bloodOfIlidon = int.Parse(Console.ReadLine());

            double totalPowerOfGamers = numberOfPeople * powerOfOnePersonInGroup;
            if(bloodOfIlidon > totalPowerOfGamers)
            {
                Console.WriteLine($"You are not prepared! You need {bloodOfIlidon - totalPowerOfGamers} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalPowerOfGamers - bloodOfIlidon} points.");
            }
        }
    }
}
