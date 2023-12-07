using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Shape, ICheckShape
    {
        public Rectangle(double sideA, double sideB, double sideC, double sideD)
        {
            a = sideA;
            b = sideB;
            c = sideC;
            d = sideD;
        }

        public Rectangle(double sideE)
        {
            a = b = c = d = sideE;
        }
        public double RectanglePerimetr()
        {
            double rectanglePerimetr = a + b + c + d;
            return rectanglePerimetr;
        }
        public double RectangleArea()
        {
            double rectangleArea = a * b;
            return rectangleArea;
        }

        public override void ShapeInfo()
        {
            Console.WriteLine($"The sides of the rectangle are equal: {a}, {b}, {c}, {d}");
            Console.WriteLine($"The perimeter of the rectangle is equal to: {RectanglePerimetr()}");
            Console.WriteLine($"The area of the rectangle is equal to: {RectangleArea()}");
        }

        //public bool RectangleCheck()
        //{
        //    if (a != c | b != d)
        //    {
        //        Console.WriteLine("fatal error!!! there is no rectangle with the specified parameters");
        //    }
        //    else
        //    {
        //        RectanglePerimetr();
        //        RectangleArea();
        //    }
        //    return false;
        //}

        public void Check()
        {
            if (a != c | b != d)
            {
                Console.WriteLine("fatal error!!! there is no rectangle with the specified parameters");
            }
            else
            {
                RectanglePerimetr();
                RectangleArea();
                ShapeInfo();
            }
            //return false;

        }
    }
}
