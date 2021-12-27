using System;

namespace task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "indul'gencia";
            string result1 = str.Substring(6,1)
                + str.Substring(3,3)
                + str.Substring(2,1)
                + str.Substring(7,2);
            Console.WriteLine(result1); //выводит "gul'den"

            string result2 = str.Substring(9, 1)
                + str.Substring(7, 1)
                + str.Substring(4, 2);
            Console.WriteLine(result2); //выводит "cel'"

        }
    }
}
