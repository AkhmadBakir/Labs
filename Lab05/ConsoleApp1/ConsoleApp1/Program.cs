using System;
class Lab06
{
        static void Main()
    {
        int[] a = new int[5];
        Input(a);
        int sum = Sum(a);
        Console.WriteLine(sum);
        int ave = Average(a);
        Console.WriteLine(ave);
        int sumMinus = SumMinus(a);
        Console.WriteLine(sumMinus);
        int sumPlus = SumPlus(a);
        Console.WriteLine(sumPlus);
    }

    static void Input(int[] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            Console.Write("Enter value: ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    static int Sum(int[] a)
    {
        int result = a[0] + a[1] + a[2] + a[3] + a[4];
        return result;
    }
    static int Average(int[] a)
    {
        int result = (a[0] + a[1] + a[2] + a[3] + a[4]) / a.Length;
        return result;
    }
    static int SumMinus(int[] a)
    {
        int sumMinus=0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0)
                sumMinus += a[i];
        }
        return sumMinus;                              
    }
    static int SumPlus(int[] a)
    {
        int sumPlus = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0)
                sumPlus += a[i];
        }
        return sumPlus;
    }
}
    