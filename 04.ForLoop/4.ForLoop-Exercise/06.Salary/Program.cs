using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            for (int i = 1; i <= tab; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 150.00;
                }
                else if (site == "Instagram")
                {
                    salary -= 100.00;
                }
                else if (site == "Reddit")
                {
                    salary -= 50.00;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    i = tab + 1;
                }
            }
            if(salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
