
using System;
    public class Program
    {
        public static double Method(double num)
        {
            double y = 1;
            double oldy;
            do
            {
                oldy = y;
                y = (y + num / y) / 2;
            }
            while (oldy != y);
            return y;
        }

        public static void Main()
        {
            double target = Convert.ToDouble(Console.ReadLine());
            double x = Method(target);
            Console.WriteLine(x);
            Console.WriteLine(x * x);
        }
    }