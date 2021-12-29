using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(CountY(x));
        }

        static double CountY(double x)
        {
            if (x < 0) { return (0); }
            else if (x <= 1) { return (x* x); }
            else { return (1); }
        }
    }
}
