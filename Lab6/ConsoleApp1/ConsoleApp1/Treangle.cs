class Treangle
{
    private double sideA;
    private double sideB;
    private double sideC;
    public void NewTreangle()
    {
        Console.Write("Enter the length of the side of the triangle: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of the side of the triangle: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of the side of the triangle: ");
        sideC = double.Parse(Console.ReadLine());
    }

    public void SetSide(double a, double b, double c)
    {
        sideA = a;
        sideB = b;
        sideC = c;
    }
    public double GetSideA() => sideA;
    public double GetSideB() => sideB;
    public double GetSideC() => sideC;
    public double TreanglePerimetr(double a, double b, double c)
    {
        double treanglePerimetr = a + b + c;
        return treanglePerimetr;
    }
    public double TreangleArea(double a, double b, double c)
    {
        double treangleArea = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
        return treangleArea;
    }
    public double TreangleInfo(double a, double b, double c)
    {
        Console.WriteLine($"The sides of the triangle are equal: {a}, {b}, {c}");
        Console.WriteLine($"The perimeter of the triangle is equal to: {TreanglePerimetr(a, b, c)}");
        Console.WriteLine($"The area of the triangle is equal to: {TreangleArea(a, b, c)}");
        return 0;
    }

    public bool TreangleCheck(double a, double b, double c)
    {
        if ((a + b) < c | (b + c) < a | (a + c) < b)
        {
            Console.WriteLine("fatal error!!! there is no triangle with the specified parameters");
        }
        else
        {
            TreanglePerimetr(a, b, c);
            TreangleArea(a, b, c);
            TreangleInfo(a, b, c);
        }
        return false;
    }
}
