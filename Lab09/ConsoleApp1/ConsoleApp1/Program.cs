using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Treangle treangle1 = new Treangle(4,4,4);
            treangle1.Check();

            Rectangle rectangle1 = new Rectangle(4);
            rectangle1.Check();

            Сircle circle1 = new Сircle(3);
            circle1.Check();

            Shape[] shapes = { new Treangle(1, 1, 1), new Rectangle(3, 3, 3, 3), new Сircle(5) };
            foreach (var shape in shapes)
            {
                shape.ShapeInfo();
                Console.WriteLine();
            }



        }


        
    }
}
