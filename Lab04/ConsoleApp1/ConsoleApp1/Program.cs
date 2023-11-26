using System;

namespace ConsoleApp1
{
    internal class Operation
    {
        public static double TreangleArea(double a, double b, double c)
        {
            bool ok = Treangle(a, b, c);
            if (ok)
            {
                double halfP = (a + b + c) / 2;
                double triangleArea = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
                return triangleArea;
            }
            else
            {
                return 0;
            }
        }
        public static bool Treangle(double a, double b, double c)
        {
            bool ok = default;
            if (a + b > c && b + c > a && c + a > b)
                ok = true;
            return ok;
        }
        public static double TreangleArea(double d)
        {
            double halfP = 3 * d / 2;
            double triangleArea = Math.Sqrt(halfP * (halfP - d) * (halfP - d) * (halfP - d));

            return triangleArea;
        }
    }
    public class Program
    {
        public static void Main()
        {
            ConsoleKey response;
            do
            {
                Console.Write("Треугольник равносторонний? [Y/N] ");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                    Console.WriteLine("  Нажмите Y/N");                
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);            
            
            if (response == ConsoleKey.Y)
            {
                Console.WriteLine("Введите длину стороны треугольника:");
                double d = Convert.ToDouble(Console.ReadLine());
                double S = Operation.TreangleArea(d);
                Console.WriteLine("Площадь треугольника равна: {0}", S);
            }

            else 
            {
                Console.WriteLine("Введите длины сторон треугольника:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double S = Operation.TreangleArea(a,b,c);
                Console.WriteLine("Площадь треугольника равна: {0}", S);
            }

        }

    }


}
