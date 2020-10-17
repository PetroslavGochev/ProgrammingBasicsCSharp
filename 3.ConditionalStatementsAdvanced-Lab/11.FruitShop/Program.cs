using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
           switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            double bananaPrice = quantity * 2.5;
                            Console.WriteLine($"{bananaPrice:f2}");
                            break;
                        case "apple":
                            double applePrice = quantity * 1.20;
                            Console.WriteLine($"{applePrice:f2}");
                            break;
                        case "orange":
                            double orangePrice = quantity * 0.85;
                            Console.WriteLine($"{orangePrice:f2}");
                            break;
                        case "grapefruit":
                            double grapefruitPrice = quantity * 1.45;
                            Console.WriteLine($"{grapefruitPrice:f2}");
                            break;
                        case "kiwi":
                            double kiwiPrice = quantity * 2.70;
                            Console.WriteLine($"{kiwiPrice:f2}");
                            break;
                        case "pineapple":
                            double pineapplePrice = quantity * 5.50;
                            Console.WriteLine($"{pineapplePrice:f2}");
                            break;
                        case "grapes":
                            double grapesPrice = quantity * 3.85;
                            Console.WriteLine($"{grapesPrice:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            double bananaPrice = quantity * 2.70;
                            Console.WriteLine($"{bananaPrice:f2}");
                            break;
                        case "apple":
                            double applePrice = quantity * 1.25;
                            Console.WriteLine($"{applePrice:f2}");
                            break;
                        case "orange":
                            double orangePrice = quantity * 0.90;
                            Console.WriteLine($"{orangePrice:f2}");
                            break;
                        case "grapefruit":
                            double grapefruitPrice = quantity * 1.60;
                            Console.WriteLine($"{grapefruitPrice:f2}");
                            break;
                        case "kiwi":
                            double kiwiPrice = quantity * 3.00;
                            Console.WriteLine($"{kiwiPrice:f2}");
                            break;
                        case "pineapple":
                            double pineapplePrice = quantity * 5.60;
                            Console.WriteLine($"{pineapplePrice:f2}");
                            break;
                        case "grapes":
                            double grapesPrice = quantity * 4.20;
                            Console.WriteLine($"{grapesPrice:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
