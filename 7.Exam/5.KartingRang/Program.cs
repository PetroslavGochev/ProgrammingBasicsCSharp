using System;

namespace _5.KartingRang
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer;
            int minTime = int.MaxValue;
            string winner = "";
            int gold = 0;
            int silver = 0;
            int bronze = 0;
            while((nameOfPlayer = Console.ReadLine())!= "Finish")
            {
                int minutes = int.Parse(Console.ReadLine());
                int seconds = int.Parse(Console.ReadLine());
                int totalSecond = minutes * 60 + seconds;
                if(totalSecond < 55)
                {
                    gold++;
                    
                }
                else if (totalSecond >= 55 && totalSecond <= 85)
                {
                    silver++;
                }
                else if (totalSecond > 85 && totalSecond <= 120)
                {
                    bronze++;
                }
                if (totalSecond < minTime)
                {
                    minTime = totalSecond;
                    winner = nameOfPlayer;
                }
            }
            

            Console.WriteLine($"With {minTime / 60} minutes and {minTime % 60} seconds {winner} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {gold} Gold {silver} Silver and {bronze} Bronze cards!");
           


        }
    }
}
