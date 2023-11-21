
namespace ConsoleApp2
{
    internal class Program
    {
        public struct Distance
        {
            public int feet;
            public int inch;
        }
        static void Main(string[] args)
        {
            {
                Distance length1;
                Console.WriteLine("Введите футы первого отрезка");
                length1.feet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите дюймы первого отрезка");
                length1.inch = Convert.ToInt32(Console.ReadLine());
                Distance length2;
                Console.WriteLine("Введите футы второго отрезка");
                length2.feet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите дюймы второго отрезка");
                length2.inch = Convert.ToInt32(Console.ReadLine());
                Distance length3;
                length3.feet = (length1.feet + length2.feet) + ((length1.inch + length2.inch) / 12);
                length3.inch = (length1.inch + length2.inch) % 12;
                Console.WriteLine("Длина третьего отрезка равна {0}'-{1}\"", length3.feet, length3.inch);
            }
        }
    }
}