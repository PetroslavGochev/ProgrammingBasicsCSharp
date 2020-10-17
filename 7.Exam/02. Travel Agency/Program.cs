using System;

namespace _02._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTickets = int.Parse(Console.ReadLine());
            int budgetOfClient = int.Parse(Console.ReadLine());
            int priceForOneTicket = int.Parse(Console.ReadLine());

            int totalPrice = numberOfTickets * priceForOneTicket;
            if (totalPrice <= budgetOfClient)
            {
                Console.WriteLine($"You can sell your client {numberOfTickets} tickets for the price of {totalPrice}$!");
                Console.WriteLine($"Your client should become a change of {budgetOfClient - totalPrice}$!");
            }
            else
            {
                Console.WriteLine($"The budget of {budgetOfClient}$ is not enough. Your client can't buy {numberOfTickets} tickets with this budget!");
            }
        }
    }
}
