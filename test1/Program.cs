using System;

namespace test1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = 0;
            int n = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        Console.WriteLine(i + "不是素数");
                        n++;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i + " ");
                    num++;
                }
            }
            Console.WriteLine(num);
            Console.WriteLine(n + 1);
        }
    }
}