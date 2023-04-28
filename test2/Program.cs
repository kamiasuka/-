using System;

namespace test2
{
    internal class Rectangle
    {
        private int length;
        private int width;

        public void area(int num1, int num2)
        {
            length = num1;
            width = num2;
        }

        public void Dispaly()
        {
            Console.WriteLine("length is {0}", length);
            Console.WriteLine("width is {0}", width);
            Console.WriteLine("area is {0}", length * width);
        }

        private class SRectangle
        {
            private static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                Console.WriteLine("length is:");
                string str1 = Console.ReadLine();

                Console.WriteLine("width is:");
                string str2 = Console.ReadLine();
                int a = Convert.ToInt32(str1);
                int b = Convert.ToInt32(str2);
                r.area(a, b);
                r.Dispaly();
            }
        }
    }
}