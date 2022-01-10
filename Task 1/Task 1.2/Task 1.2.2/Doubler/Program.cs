using System;
using System.Text;

namespace Doubler
{
    class Program
    {
        public static StringBuilder Doubler(string first, string second)
        {
            StringBuilder res = new StringBuilder(first);
            for (int i = 0; i < res.Length; i++)
            {
                if (second.Contains(res[i]))
                {
                    res = res.Insert(i + 1, res[i++]);
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string first = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string second = Console.ReadLine();

            Console.WriteLine("Result string:");
            Console.WriteLine(Doubler(first, second));
        }
    }
}
