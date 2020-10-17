using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekends = int.Parse(Console.ReadLine());
            double weekInSofia = (48 - numberOfWeekends) * 3.00 / 4.00;
            double gameInHome = numberOfWeekends;
            double gameOfHolidays = numberOfHolidays * 2.00 / 3.00;
            double totalGames = weekInSofia + gameInHome + gameOfHolidays;
            double gamesInOneYear = 0.0;
            if ( year == "leap")
            {
                gamesInOneYear = (totalGames * 0.15)+totalGames; 
            }
            else
            {
                gamesInOneYear = totalGames;
            }
            Console.WriteLine($"{Math.Floor(gamesInOneYear)}");
        }
    }
}
