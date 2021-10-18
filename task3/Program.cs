using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x, e;
            Console.WriteLine("enter x:");
            x = double.Parse(Console.ReadLine());
            e = Math.E;
            y = Math.Pow(e,(1-(x*x))/(1+(x*x)));
            Console.WriteLine("y = ", y);
        }
    }
}
