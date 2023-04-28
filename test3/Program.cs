using System;

namespace test3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*//*******************************************************************************
            水仙花数
            int i = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i <= 200; i++)
            {
                int a = i / 100;
                int b = i % 100 / 10;
                int c = i % 10;

                int x = a * a * a + b * b * b + c * c * c;

                if (x == i)
                {
                    Console.WriteLine(i + "YES");
                }
                else
                {
                    Console.WriteLine(i + "NO");
                }
            }
            */

            /*//**********************************************************************************
            九九乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            */

            /*//************************************************************************************
            //求数组最大最小值
            int[] arr = { 21, 27, 3, 45, 15, 6, 77, 58, 39 };
            int max = arr[0], min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("max:{0}min:{1}", max, min);
            */

            static void Add(ref int num1)
            {
                num1++;
                Console.WriteLine("num1的值是：{0}", num1);
            }

            int num1 = 10;
            Add(ref num1);
            Console.WriteLine("num1的值是：{0}", num1);
        }
    }
}