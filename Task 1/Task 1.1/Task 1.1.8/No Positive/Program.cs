using System;

namespace No_Positive
{
    
    class Program
    {
        public static void ChangeElems(int[,,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (arr[i,j,k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        public static int[,,] Input()
        {
            Random rand = new Random();
            int[,,] arr = new int[3,3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        arr[i, j, k] = rand.Next(-100, 100);
                    }
                }
            }

            return arr;
        }

        public static void Show(int[,,] arr)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            ChangeElems(arr);
            Console.WriteLine("Changed Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,,] arr = Input();
            Show(arr);
        }
    }
}
