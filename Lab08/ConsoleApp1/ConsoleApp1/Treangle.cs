public class Treangle
{
    public double sideA;
    public double sideB;
    public double sideC;

    public double a;
    public double b;
    public double c;
        
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
    public double TreangleInfo()
    {
        Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
        Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr()}");
        Console.WriteLine($"The area of the triangle is equal to: {TreangleArea()}");
        return 0;
    }

    public bool TreangleCheck()
    {
        if ((a + b) < c | (b + c) < a | (a + c) < b)
        {
            Console.WriteLine("fatal error!!! there is no triangle with the specified parameters");
        }
        else
        {
            TreanglePerimetr();
            TreangleArea();
            TreangleInfo();
        }
        return false;
    }
}
