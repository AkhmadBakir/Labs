//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//public class Program
//{
//    public static int Sum(int num)
//    {
//        int sum = 0;
//        while (num != 0);
//        {
//            sum += num % 10;
//            num /= 10;
//        }
//        return sum;
//    }    
//    public static void Main(string[] args)
//        {
//            int num = 12345;
//            int sum = Sum(num);
//            Console.WriteLine("Сумма цифр числа равна {0}", sum);
//        }
//}
using System;

public class Program
{
    public static int SumNum(int n)
    {
        int s = 0;
        while (n != 0)
        {
            s += n % 10;
            n /= 10;
        }
        return s;
    }

    public static void Main()
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = SumNum(num);
        Console.WriteLine("Сумма цифр числа {0} равна {1}", num, sum);
    }
}