using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloor = int.Parse(Console.ReadLine());
            int numberOfRoom = int.Parse(Console.ReadLine());
            int maxFloor = numberOfFloor;

            for (int floor = numberOfFloor; floor >= 1; floor--)
            {
                for (int room = 0; room < numberOfRoom; room++)
                {
                    if (floor == numberOfFloor)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (floor % 2 == 1)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
