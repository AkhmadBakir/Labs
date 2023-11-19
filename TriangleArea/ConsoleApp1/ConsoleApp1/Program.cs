using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны равностороннего треугольника");
            double sideLength = Convert.ToInt32(Console.ReadLine());
            double halfTrianglePerimeter = 3 * sideLength / 2;
            double triangleArea = Math.Sqrt(halfTrianglePerimeter * (Math.Pow ((halfTrianglePerimeter - sideLength), 3)));
            Console.WriteLine("Площадь равностороннего треугольника со стороной {0} равна {1}", sideLength, triangleArea.ToString("0.00"));
        
        }
    }
}
