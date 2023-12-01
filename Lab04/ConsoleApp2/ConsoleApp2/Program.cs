using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{    
    public class Program
    {
        static void Func(double a, double b, double c, out double x1, out double x2, out int flag)
        {
            double d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (d > 0)
            {
                flag = 1;
            }
            else if (d == 0)
            {
                flag = 0;
            }
            else
            {
                flag = -1;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Введите значение коэффиента a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение коэффиента b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение коэффиента c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double x1;
            double x2;
            int flag;
            Func(a, b, c, out x1, out x2, out flag);
            if (flag > 0) Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны: x1 = {x1}, x2 = {x2}");
            else if (flag == 0) Console.Write($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c} один: x1= x2 = {x1}");
            else Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет.");
        }

    }


}
