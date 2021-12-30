using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double n = double.Parse(Console.ReadLine());
            for (double i=1; i<=n; i++)
            {
                result = result + ((2*i-1)/(2*i+1));
            }
            Console.WriteLine(result);
        }
    }
}
