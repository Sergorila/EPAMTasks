using System;

namespace Triangle
{
    class Program
    {
        public static int Input()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            if (N > 0)
            {
                return N;
            }
            else
            {
                throw new Exception("Incorrect input");
            }
        }

        public static void Show()
        {
            int N = Input();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Show();
        }
    }
}
