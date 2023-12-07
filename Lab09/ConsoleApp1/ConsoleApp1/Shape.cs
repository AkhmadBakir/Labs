using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface ICheckShape
    {
        void Check();
    }

    abstract class Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double r { get; set; }

        public abstract void ShapeInfo();

        //public override void ShapeInfo()
        //{
        //    Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
        //    Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr()}");
        //    Console.WriteLine($"The area of the triangle is equal to: {TreangleArea()}");
        //}
    }
}
