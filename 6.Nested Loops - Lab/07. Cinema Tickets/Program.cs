using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie;
            double sumStandard = 0.0;
            double sumKids = 0.0;
            double sumStudent = 0.0;
            double totalTickets = 0.0;
            while ((movie = Console.ReadLine())!= "Finish")
            {   
                int freePlace = int.Parse(Console.ReadLine());
                string typeOfTickets;
                double busyPlace = 0;
                while ((typeOfTickets = Console.ReadLine()) != "End")
                {
                    if (typeOfTickets == "standard")
                    {
                        sumStandard++;
                    }
                    else if (typeOfTickets == "kid")
                    {
                        sumKids++;
                    }
                    else
                    {
                        sumStudent++;
                    }
                    totalTickets++;
                    busyPlace++;
                    if (busyPlace == freePlace)
                    {
                        break;
                    }
                }
                double average = busyPlace * 100 / freePlace;
                Console.WriteLine($"{movie} - {average:f2}% full.");
            }
            double studentAverage = sumStudent * 100 / totalTickets;
            double standardAverage = sumStandard * 100 / totalTickets;
            double kidsAverage = sumKids * 100 / totalTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentAverage:f2}% student tickets.");
            Console.WriteLine($"{standardAverage:f2}% standard tickets.");
            Console.WriteLine($"{kidsAverage:f2}% kids tickets.");
        }
    }
}
