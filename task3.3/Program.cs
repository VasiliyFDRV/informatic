using System;

namespace task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("enter x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("y = " + Funk(x));
        }
        static double Funk(double x)
        {
            return Math.Pow(Math.E, (1 - (x * x)) / (1 + (x * x)));
        }
    }
}
