using System;

namespace Task8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            double result = 0;
            double n = 1;
            while (result<=a)
            {
                result += (1 / n);
                n += 1;
            }
            Console.WriteLine(n);
        }
    }
}
