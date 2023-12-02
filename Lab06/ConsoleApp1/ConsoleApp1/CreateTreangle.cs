using System;
class Program
{
    static void Main()
    {
        Triangle first = new Triangle();
        Treangle.TreangleInfo(first);
        //double sideA = NewTreangle.TreangleSide();
        //double sideB = NewTreangle.TreangleSide();
        //double sideC = NewTreangle.TreangleSide();
        //NewTreangle.TreangleCheck(sideA, sideB, sideC);
    }
    static void TreangleInfo(double a, double b, double c)
    {
        Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
        Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr(a, b, c)}");
        Console.WriteLine($"The area of the triangle is equal to: {TreangleArea(a, b, c)}");
    }
    static Treangle NewTreangle()
    {
        Console.Write("Enter the length of the side of the triangle: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of the side of the triangle: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of the side of the triangle: ");
        double sideC = double.Parse(Console.ReadLine());
        return sideA;
    }
}

//class NewTreangle
//{
//    public static double TreangleSide()
//    {
//        Console.Write("Enter the length of the side of the triangle: ");
//        double x = double.Parse(Console.ReadLine());
//        return x;
//    }
//    public static double TreanglePerimetr(double a, double b, double c)
//    {
//        double treanglePerimetr = a + b + c;
//        return treanglePerimetr;
//    }
//    public static double TreangleArea(double a, double b, double c)
//    {
//        double treangleArea = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
//        return treangleArea;
//    }
//    //public static double TreangleInfo(double a, double b, double c)
//    //{
//    //    Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
//    //    Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr(a, b, c)}");
//    //    Console.WriteLine($"The area of the triangle is equal to: {TreangleArea(a, b, c)}");
//    //    return 0;
//    //}

//    public static bool TreangleCheck(double a, double b, double c)
//    {
//        if ((a + b) < c | (b + c) < a | (a + c) < b)
//        {
//            Console.WriteLine("FATAL ERROR!!! There is no triangle with the specified parameters");
//        }
//        else
//        {
//            TreanglePerimetr(a, b, c);
//            TreangleArea(a, b, c);
//            TreangleInfo(a, b, c);
//        }
//        return false;
//    }
//}