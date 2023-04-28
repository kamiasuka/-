using System;

namespace 冒泡排序
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //冒泡排序是一种交换排序算法，主要是序列中的相邻元素之间比较和位置交换，
            //这会导致序列中小（大）的元素慢慢的“浮向”序列的右端，从而导致序列降序（升序），
            //就像水中的气泡一样，所以称为“冒泡排序。

            int[] arr = { 3, 5, 1, 7, 4, 9, 6, 8, 10, 2 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])//降序排序改成arr[j] < arr[j + 1]
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\n", arr[i]);
            }
        }
    }
}