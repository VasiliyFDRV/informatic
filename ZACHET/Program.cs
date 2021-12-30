using System;

namespace ZACHET
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckLuna(num));
            Console.WriteLine(LunaSum(num));
            PrintArr(NumToLuna(num));

        }

        static bool CheckLuna(int num)
        {
            int[] lunaArr = NumToLuna(num);
            int numSum = 0;
            foreach (int i in lunaArr) { numSum += i; }
            return (numSum%10==0);
        }

        static int LunaSum (int num)
        {
            int[] lunaArr = NumToLuna(num);
            int numSum = 0;
            foreach (int i in lunaArr) { numSum += i; }
            return (numSum);
        }

        static int[] NumToLuna (int num)
        {
            int[] numArr = intToArr(num);
            for (int i = 0; i < numArr.Length; i++)
            {
                if (i % 2 == 0) { numArr[i] *= 2; }
                if (numArr[i] > 9) { numArr[i] -= 9; }
            }
            return (numArr);
        }

        static int[] intToArr(int num)
        {
            int copyNum = num;
            int qty = 0;
            while(copyNum>0)
            {
                qty+=1;
                copyNum /= 10;
            }
            copyNum = num;
            int[] numArr = new int[qty];
            for (int i = qty-1; i >= 0; i--)
            {
                numArr[i] = copyNum%10;
                copyNum /= 10;
            }
            
            return (numArr);
        }
        
        static void PrintArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
