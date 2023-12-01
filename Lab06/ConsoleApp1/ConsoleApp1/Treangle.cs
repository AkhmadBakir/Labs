

using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Triangle
    {
        public static void Main()
        {
            double sideA = TreangleSide();
            double sideB = TreangleSide();
            double sideC = TreangleSide();

            bool check = TreangleCheck(sideA, sideB, sideC);
            if (check == true)
            {
                Console.WriteLine("FATAL ERROR!!! There is no triangle with the specified parameters");
            }
            else
            {
                TreanglePerimetr(sideA, sideB, sideC);
                TreangleArea(sideA, sideB, sideC);
                TreangleInfo(sideA, sideB, sideC);
            }
        }

        static double TreangleSide()
        {
            Console.Write("Enter the length of the side of the triangle: ");
            double x = double.Parse(Console.ReadLine());
            return x;
        }
        static double TreanglePerimetr(double a, double b, double c)
        {
            double treanglePerimetr = a + b + c;
                return treanglePerimetr;
        }
        static double TreangleArea(double a, double b, double c)
        {
            double treangleArea = Math.Sqrt(( (a+b+c)/2) * ( ((a+b+c)/2-a) * ((a+b+c)/2-b) * ((a+b+c)/2-c) ));
            return treangleArea;
        }
        static double TreangleInfo(double a, double b, double c)
        {
            Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
            Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr(a, b, c)}");
            Console.WriteLine($"The area of the triangle is equal to: {TreangleArea(a, b, c)}");
            return 0;
        }
        static bool TreangleCheck(double a, double b, double c)
        {
            if ((a + b) < c | (b + c) < a | (a + c) < b)
            {
                //Console.WriteLine("FATAL ERROR!!! There is no triangle with the specified parameters");
            }
            return false;               
        }
    }
}
