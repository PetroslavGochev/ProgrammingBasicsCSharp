using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int checkBook = 0;
            string checkBooks = Console.ReadLine();
            while (checkBooks != favouriteBook)
            {
                checkBook++;
                checkBooks = Console.ReadLine();
                if(checkBooks == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkBook} books.");
                    break;
                }
            }
            if (checkBooks == favouriteBook)
            {
                Console.WriteLine($"You checked {checkBook} books and found it.");
            }


        }
    }
}
