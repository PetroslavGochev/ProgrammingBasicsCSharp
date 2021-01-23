
using System;
using System.Diagnostics.Tracing;
using System.Net;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string opeartor = Console.ReadLine();
            double result = 0.0;
            string evenOrodd = "";
            if (opeartor == "+" || opeartor == "-" || opeartor == "*")
            {
                if(opeartor == "+")
                {
                    result = n1 + n2;
                    if(result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                }
                else if (opeartor == "-")
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                }
                else
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                }
            }
            else if (opeartor == "/")
            {
                result = n1 / n2;
            }
            else
            {
                result = n1 % n2;
            }
            if (opeartor == "+" || opeartor == "-" || opeartor == "*")
            {
                Console.WriteLine($"{n1} {opeartor} {n2} = {result} - {evenOrodd}");
            }
            else if (opeartor == "/")
            {
                if(n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                } 
            }
        }
    }
}
