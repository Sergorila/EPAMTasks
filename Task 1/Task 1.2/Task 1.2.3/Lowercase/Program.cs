using System;
using System.Text;

namespace Lowercase
{
    class Program
    {
        public static int LowerCount(string s)
        {
            char[] separators = { ',', '.', '(', ')', ':', ' ', '"', ';' };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (var word in words)
            {
                if (char.IsLower(word[0]))
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

            Console.WriteLine($"Count = {LowerCount(s)}");
        }
    }
}
