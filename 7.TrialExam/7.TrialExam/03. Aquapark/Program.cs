using System;

namespace _03._Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfHours = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            double priceForOnePerson = 0.0;
            double totalSum = 0;

            if(month == "march" || month == "april" || month == "may")
            {
                priceForOnePerson = 10.50;
                
                if(timeOfTheDay == "day")
                {
                    if(numberOfPeople >= 4)
                    {
                        priceForOnePerson = priceForOnePerson * 0.9;                       
                    }
                    if(numberOfHours >= 5)
                    {
                        priceForOnePerson =priceForOnePerson* 0.5;
                    }                   
                    totalSum += (priceForOnePerson * numberOfHours) * numberOfPeople; 
                }
                else
                {
                    priceForOnePerson = 8.40;
                    if (numberOfPeople >= 4)
                    {
                        priceForOnePerson =priceForOnePerson*0.9;
                    }
                    if (numberOfHours >= 5)
                    {
                        priceForOnePerson = priceForOnePerson*0.5;
                    }
                    totalSum += (priceForOnePerson * numberOfHours) * numberOfPeople;
                }
            }
            else
            {
                priceForOnePerson = 12.60;
                if (timeOfTheDay == "day")
                {
                    if (numberOfPeople >= 4)
                    {
                        priceForOnePerson =priceForOnePerson* 0.9;
                    }
                    if (numberOfHours >= 5)
                    {
                        priceForOnePerson = priceForOnePerson*0.5;
                    }
                    totalSum += (priceForOnePerson * numberOfHours) * numberOfPeople;
                }
                else
                {
                    priceForOnePerson = 10.20;
                    if (numberOfPeople >= 4)
                    {
                        priceForOnePerson = priceForOnePerson* 0.9;
                    }
                    if (numberOfHours >= 5)
                    {
                        priceForOnePerson =priceForOnePerson * 0.5;
                    }
                    totalSum += (priceForOnePerson * numberOfHours) * numberOfPeople;
                }
            }
            Console.WriteLine($"Price per person for one hour: {priceForOnePerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalSum:f2}");
        }
    }
}
