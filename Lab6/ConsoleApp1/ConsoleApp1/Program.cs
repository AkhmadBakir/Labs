class Program
{
    public static void Main()
    {
        Treangle treangle1 = new Treangle();
        treangle1.NewTreangle();
        treangle1.TreangleCheck(treangle1.GetSideA(), treangle1.GetSideB(), treangle1.GetSideC());

        //Treangle treangle2 = new Treangle();
        //treangle2.NewTreangle();
        //treangle1.TreangleCheck(treangle2.GetSideA(), treangle2.GetSideB(), treangle2.GetSideC());
    }
}