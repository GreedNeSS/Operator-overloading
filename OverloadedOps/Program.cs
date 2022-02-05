using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point(40, 40);

            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");
            Console.WriteLine();

            Console.WriteLine($"p1 == p2: {p1 == p2}");
            Console.WriteLine($"p1 != p2: {p1 != p2}");
            Console.WriteLine();

            Console.WriteLine($"p1 < p2: {p1 < p2}");
            Console.WriteLine($"p1 > p2: {p1 > p2}");
            Console.WriteLine();

            Console.WriteLine($"p1 <= p2: {p1 <= p2}");
            Console.WriteLine($"p1 >= p2: {p1 >= p2}");
            Console.WriteLine();

            Console.WriteLine($"p1 + p2: {p1 + p2}");
            Console.WriteLine($"p1 - p2: {p1 - p2}");
            Console.WriteLine();

            Console.WriteLine($"p1 + 100: {p1 + 100}");
            Console.WriteLine($"100 + p1: {100 + p1}");
            Console.WriteLine();

            Console.WriteLine($"p1 - 100: {p1 - 100}");
            Console.WriteLine($"1000 - p1: {1000 - p1}");
            Console.WriteLine();

            Point p3 = new Point(90, 5);
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p3 += p2: {p3 += p2}");
            Console.WriteLine();

            Point p4 = new Point(0, 500);
            Console.WriteLine($"p4: {p4}");
            Console.WriteLine($"p4 -= p3: {p4 -= p3}");
            Console.WriteLine();

            Point p5 = new Point(1, 1);
            Console.WriteLine($"++p5: {++p5}");
            Console.WriteLine($"--p5: {--p5}");
            Console.WriteLine();

            Point p6 = new Point(20, 20);
            Console.WriteLine($"p6++: {p6++}");
            Console.WriteLine($"p6--: {p6--}");
            Console.WriteLine();
        }
    }
}
