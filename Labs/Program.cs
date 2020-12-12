using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxPrice = 500000;

            int maxBuyers = 0;
            int optimalPrice = 0;

            for (int x = 1; x <= MaxPrice; x++)
            {
                int y = (int) (x * Math.Exp(-x / 50000.0));

                if (maxBuyers < y)
                {
                    maxBuyers = y;
                    optimalPrice = x;
                }
            }

            Console.WriteLine(optimalPrice);
            Console.ReadKey();
        }
    }
}
