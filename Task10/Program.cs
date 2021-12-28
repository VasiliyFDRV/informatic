using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 =
            {
                {1,2,3,4,5},
                {2,5,8,11,14 },
                {3,8,13,11,23 }
            };
            int[,] arr2 =
            {
                {1,2,3,4,5},
                {2,5,8,11,14 },
                {1,3,5,7,9 }
            };
            MoreOrLess(arr1);
            SumLine(arr1);
        }
        static void MoreOrLess(int[,] a)
        {
            bool result = true;
            for (int j = 0; j <= a.GetLength(1)-1; j++)
            {
                for (int i = 1; i <= a.GetLength(0)-1; i++)
                {

                    if (a[i, j] < a[i - 1, j])
                    {
                        result = false;
                        Console.WriteLine($"ERROR: elements from {i - 1} {j}, and {i} {j}");
                        break;
                    }
                    if (result == false) { break; }
                }
            }
            if (result == true)
            {
                Console.WriteLine("the array is composed CORRECTLY");
            }          
        }
        static void SumLine(int[,] a)
        {
            for (int y = 0; y<=a.GetLength(0)-1; y++)
            {
                int sum = 0;
                Console.Write(y+" - ");
                for (int x = 0; x <= a.GetLength(1)-1; x++)
                {
                    if (a[y,x] % 2 == 0) { sum += a[y,x]; }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
