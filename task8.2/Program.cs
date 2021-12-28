using System;

namespace task8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.WriteLine("Enter quantity of pairs");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Enter R for both resistors");
                r+= (double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine()))/2; ;
            }
            Console.WriteLine(r);
        }
    }
}
