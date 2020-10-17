using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lenghtCake = int.Parse(Console.ReadLine());
            int cakeTotal = widthCake * lenghtCake;
            string pieceOfCake;
            int sum = 0;
            
            while((pieceOfCake = Console.ReadLine())!= "STOP")
            {
                sum += int.Parse(pieceOfCake);
                if (sum >= cakeTotal)
                {
                    Console.WriteLine($"No more cake left! You need {sum - cakeTotal} pieces more.");
                    break;
                }
            }
            if (pieceOfCake == "STOP")
            {
                Console.WriteLine($"{cakeTotal - sum} pieces are left.");
            }
        }
    }
}
