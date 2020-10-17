using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            decimal one = 0.01M;
            decimal two = 0.02M;
            decimal five = 0.05M;
            decimal ten = 0.10M;
            decimal twenty = 0.20M;
            decimal fifty = 0.50M;
            decimal oneLv = 1;
            decimal twoLv = 2;
            int coins = 0;
            while (change != 0)
            {
                if (change >= twoLv)
                {
                    change -= twoLv;
                    coins++;
                }
                else if (change >= oneLv)
                {
                    change -= oneLv;
                    coins++;
                }
                else if (change >= fifty)
                {
                    change -= fifty;
                    coins++;
                }
                else if (change >= twenty)
                {
                    change -= twenty;
                    coins++;
                }
                else if (change >= ten)
                {
                    change -= ten;
                    coins++;
                }
                else if (change >= five)
                {
                    change -= five;
                    coins++;
                }
                else if (change >= two)
                {
                    change -= two;
                    coins++;
                }
                else
                {
                    change -= one;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
