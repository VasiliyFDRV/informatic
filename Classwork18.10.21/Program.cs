using System;

namespace Classwork18._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = (double.Parse(Console.ReadLine())) % 5;
            double y = (double.Parse(Console.ReadLine())) % 5;
            double z = (double.Parse(Console.ReadLine())) % 5;
            Console.WriteLine(Tape(x,y,z));
            Console.ReadKey();
        }

        static bool Tape(double x, double y, double z)
        {
                        
            return (((x == 0) && (y == 0) && (z != 0 )) || ((x == 0) && (z == 0) && (y != 0)) || ((z == 0) && (y == 0) && (x != 0)));
            //return x <= 0 || x >= 5;
            
            //bool b;
            //if (x > 0 || x < 5)
            //    b = false;
            //else
            //    b = true;
            //return b;
        }

    }
}
