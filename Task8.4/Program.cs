using System;

namespace Task8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity of digets");
            var k = int.Parse(Console.ReadLine());
            int result = 1;
            int c;

            for (int i = 1; i <= k; i++)
            {
                c = n % 10;
                n = n / 10;
                result *= c;
            }

            Console.WriteLine(result);
        }
    }
}
