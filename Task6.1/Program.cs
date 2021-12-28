using System;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Check(k,m,n));
        }

        static bool Check(int k, int m, int n)
        {
            return (k<0 && m<0 && n<0 && (k%2!=0 || m % 2 != 0 || n % 2 != 0));
        }
    }
}
