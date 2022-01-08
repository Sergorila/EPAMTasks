using System;

namespace Non_Negative_Sum
{
    class Program
    {
        public static int NonNegativeSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        public static int[] Input()
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            return arr;
        }

        public static void Show(int[] arr)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum = {NonNegativeSum(arr)}");
        }
        static void Main(string[] args)
        {
            int[] arr = Input();
            Show(arr);
        }
    }
}
