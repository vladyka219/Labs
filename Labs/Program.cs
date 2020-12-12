using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            for (int x = 1; x <= 50000; x++)
            {
                int y = (int) (x * Math.Exp(-x / 50000.0));

                max = Math.Max(max, y);
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
