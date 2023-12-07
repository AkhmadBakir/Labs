using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Сircle : Shape, ICheckShape
    {
        public Сircle(double radius)
        {
            r = radius;
        }
        public double СircleArea()
        {
            double circleArea = Math.PI * Math.Pow(r, 2);
            return circleArea;
        }
        public double CircleLenght()
        {
            double circleLenght = 2 * Math.PI * 3;
            return circleLenght;
        }
        public override void ShapeInfo()
        {
            Console.WriteLine($"The radius of the circle are equal: {r}");
            Console.WriteLine($"The lenght of the circle is equal to: {CircleLenght()}");
            Console.WriteLine($"The area of the circle is equal to: {СircleArea()}");
        }

        //public bool CircleCheck()
        //{
        //    if (r <= 0)
        //    {
        //        Console.WriteLine("fatal error!!! there is no circle with the specified parameters");
        //    }
        //    else
        //    {
        //        CircleLenght();
        //        СircleArea();
        //    }
        //    return false;
        //}

        public void Check()
        {
            if (r <= 0)
            {
                Console.WriteLine("fatal error!!! there is no circle with the specified parameters");
            }
            else
            {
                CircleLenght();
                СircleArea();
                ShapeInfo();
            }
            //return false;
        }
    }
}
