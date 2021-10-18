using System;

namespace task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ab, xa, ya, xb, yb;
            Console.WriteLine("enter the abscissa of the first point");
            xa = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the ordinata of the first point");
            ya = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the abscissa of the second point");
            xb = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the ordinata of the second point");
            yb = double.Parse(Console.ReadLine());

            ab = Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb)));

            Console.WriteLine("THE DISTANCE BETWEEN THE POINTS IS: " + ab);
        }
    }
}
