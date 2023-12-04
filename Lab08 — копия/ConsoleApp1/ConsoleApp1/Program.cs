class Program
{
    public static void Main()
    {
        Treangle treangle1 = new Treangle(1, 1, 1);
        treangle1.TreangleCheck();

        Treangle treangle2 = new Treangle(4);
        treangle2.TreangleCheck();

        Treangle[] treangles = new Treangle[2];
        treangles[0] = treangle1;
        treangles[1] = treangle2;

        Array.Sort(treangles);
        Console.Write(treangles.ToString());
    }
}
