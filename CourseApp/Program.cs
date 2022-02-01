using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = Math.Log(Math.Pow(b, 2) - Math.Pow(x, 2)) / Math.Log(a);
            var denominator = Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2)), 1 / 3.0);
            var y = numerator / denominator;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk > xn)
            {
                var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
                int i = 0;
                for (var x = xn; x <= xk; x += dx)
                {
                    var y = Calc(a, b, x);
                    res[i] = (x, y);
                    i++;
                }

                return res;
            }

            return new(double, double)[0];
        }

        public static (double x, double y)[] TaskB(double a, double b, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 4.1;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 0.77, 1.77, 0.2);
            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.24, 1.38, 2.38, 3.21, 0.68 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");

            var platypus1 = new Platypus("PL1", 5);

            platypus1.Age = 5;
            platypus1.Hello();
            platypus1.Age = 15;
            platypus1.Hello();
            platypus1.Age = -10;
            platypus1.Hello();

            var platypus2 = new Platypus("PL1", 5);
            Console.WriteLine(platypus2.Count);
        }
    }
}
