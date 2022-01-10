using System;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        public static int Input()
        {
            Console.Write("Enter N: ");
            int N;
            if (int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    return N;
                }
            }
            Console.WriteLine("Incorrect input");
            return 0;
        }

        public static void Show()
        {
            int N = Input();

            for (int i = 0; i < N; i++)
            {
                string line = new String('*', i);
                Console.WriteLine(line.PadLeft(N - 1) + '*' + line);
            }
        }
    }
}
