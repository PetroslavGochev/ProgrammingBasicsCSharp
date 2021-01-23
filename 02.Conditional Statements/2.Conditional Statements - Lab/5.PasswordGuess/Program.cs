using System;

namespace _5.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
          
            if (password == "ivan")
            {
                Console.WriteLine("Welcome");
            }else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
