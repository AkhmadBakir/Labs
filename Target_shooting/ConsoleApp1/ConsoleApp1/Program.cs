namespace ConsoleApp1
{
    internal class Program
    {
        public struct Point
        {
            public int x;
            public int y;
        }
        
        public static double Distance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }

        static void Main(string[] args)
        {
            {
                Point centre;
                Random random = new Random();
                centre.x = random.Next(3);
                centre.y = random.Next(3);

                for (int i = 0; i < 3; i++)
                {
                    Point shot;
                    Console.WriteLine("Введите координату x выстрела");
                    shot.x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите координату y выстрела");
                    shot.y = Convert.ToInt32(Console.ReadLine());

                    double distance = Distance(shot.x, shot.y, centre.x, centre.y);

                    if (distance <= 1)
                    {
                        Console.WriteLine("Количество очков за выстрел 10");
                    }
                    else if (distance <= 2)
                    {
                        Console.WriteLine("Количество очков за выстрел 5");
                    }
                    else
                    {
                        Console.WriteLine("Количество очков за выстрел 0");
                    }                    
                }

                Console.WriteLine("Количество очков за первый выстрел");
                int scores1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество очков за второй выстрел");
                int scores2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество очков за третий выстрел");
                int scores3 = Convert.ToInt32(Console.ReadLine());
                int sumscores = scores1 + scores2 + scores3;
                Console.WriteLine("Общее количество очков за три выстрела {0}", sumscores);
            }
        }
    }
}
    
