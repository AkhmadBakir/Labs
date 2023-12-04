using ConsoleApp1;
using System.Collections;

class Program
{
    public static void Main()
    {
        Treangle treangle1 = new Treangle();
        treangle1.NewTreangle();
        treangle1.TreangleCheck(treangle1.GetSideA(), treangle1.GetSideB(), treangle1.GetSideC());

        Treangle treangle2 = new Treangle();
        treangle2.NewTreangle();
        treangle1.TreangleCheck(treangle2.GetSideA(), treangle2.GetSideB(), treangle2.GetSideC());



        ArrayList arrayList = new ArrayList();
        arrayList.Add(treangle1);
        arrayList.Add(treangle2);
        Console.WriteLine(arrayList.ToString());
        Console.WriteLine(arrayList);
            
            
        //    treangleAreas = new ArrayList
      
        
        
        //{
        //    { treangle1, treangle2 }
        //};
        
        
        
        
        //// Initialize random number generator.
        //Random rnd = new Random();

        //// Generate 10 temperatures between 0 and 100 randomly.
        //for (int ctr = 1; ctr <= 10; ctr++)
        //{
        //    int degrees = rnd.Next(0, 100);
        //    Temperature temp = new Temperature();
        //    temp.Fahrenheit = degrees;
        //    temperatures.Add(temp);
        //}
    }
}
