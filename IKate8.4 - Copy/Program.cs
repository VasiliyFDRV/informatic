using System;

namespace IKate8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int a;
            int aMin = 10;

            while (n>0)
            {
                a = n % 10;
                n = n / 10;
                if (a<aMin) { aMin = a;}
            }

            Console.WriteLine(aMin);
        }
    }
}
