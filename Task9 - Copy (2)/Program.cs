using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + i + 1;
            }

            PrintArr(arr);
            Change(ref arr);
            PrintArr(arr);
            Console.WriteLine(QtyOfEven(arr));
            PrintArr(PartSum(arr));
            Console.ReadKey();
        }
        static void PrintArr(int[] arr)
        {
            string stringArr = arr[0].ToString();
            for (int i = 1; i < arr.Length; i++)
            {
                stringArr += ", " + arr[i];
            }
            Console.WriteLine(stringArr);
        }
        static void Change(ref int[] arr)
        {
            for (int i1 = 0; i1 < arr.Length; i1++)
            {
                int i = arr[i1];
                if (i % 2 == 0)
                {
                    i = i / 2;
                }
                arr[i1] = i;
            }

        }
        static int QtyOfEven(int[] arr)
        {
            int qty = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0) { qty++; }
            }
            return (qty);
        }
        static int[] PartSum(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] += arr[i - 1];
            }
            return (arr);
        }
    }
}
