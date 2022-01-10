using System;

namespace _2D_Array
{
    class Program
    {
        public static int EvenPosSum(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            return sum;
        }
        public static void Show(int[,] arr)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Sum = {EvenPosSum(arr)}");
        }

        public static int[,] Input()
        {
            Random rand = new Random();
            int[,] arr = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i,j] = rand.Next(1, 10);
                }
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[,] arr = Input();
            Show(arr);
        }
    }
}
