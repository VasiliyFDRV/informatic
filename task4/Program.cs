using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Funk(1,3,2) + Funk(2,5,7) + Funk(3,3,6);
            Console.WriteLine(Math.Round(x,3));
        }
        static double Funk(double n1, double n2, double n3) 
        {
            return Math.Tan((n1 + Math.Sqrt(n2)) / n3);
        }
    }
}
