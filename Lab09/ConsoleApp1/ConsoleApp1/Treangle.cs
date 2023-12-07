using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Treangle : Shape, ICheckShape
    {
        public Treangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        public Treangle(double sideD)
        {
            a = b = c = sideD;
        }

        public double TreanglePerimetr()
        {           
            double treanglePerimetr = a + b + c;
            return treanglePerimetr;
        }
        public double TreangleArea()
        {
            double treangleArea = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
            return treangleArea;
        }

        public override void ShapeInfo()
        {
            Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
            Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr()}");
            Console.WriteLine($"The area of the triangle is equal to: {TreangleArea()}");
        }


        public void Check()
        {
            if ((a + b) < c | (b + c) < a | (a + c) < b)
            {
                Console.WriteLine("fatal error!!! there is no triangle with the specified parameters");
            }
            else
            {
                TreanglePerimetr();
                TreangleArea();
                ShapeInfo();
            }
            //return false;
        }

        //public bool CheckShape()
        //{
        //    if ((a + b) < c | (b + c) < a | (a + c) < b)
        //    {
        //        Console.WriteLine("fatal error!!! there is no triangle with the specified parameters");
        //    }
        //    else
        //    {
        //        TreanglePerimetr();
        //        TreangleArea();
        //    }
        //    return false;
        //}

    }
}
