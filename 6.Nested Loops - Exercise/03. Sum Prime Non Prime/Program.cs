using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int sumPrime = 0;
            int sumNonPrime = 0;
            
            while ((number = Console.ReadLine()) != "stop")
            {
                bool flag = false;
                if (int.Parse(number) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int m = int.Parse(number) / 2;
                for(int i =  2; i<= m; i++)
                {
                    
                    if(int.Parse(number)%i == 0)
                    {
                        sumNonPrime += int.Parse(number);
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    sumPrime += int.Parse(number);
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
