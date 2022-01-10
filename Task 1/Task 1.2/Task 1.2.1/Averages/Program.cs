using System;

namespace Averages
{
    class Program
    {
        // принял решение не округлять
        public static double Average(string s)
        {
            char[] separators = {'!', '"', ',', '.',
                ' ', '(', ')', ':', ';', '?', '_' };
            
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var w in words)
            {
                Console.WriteLine(w);
            }

            double avg = 0;
            for (int i = 0; i < words.Length; i++)
            {
                avg += words[i].Length;
            }
            avg /= words.Length;

            return avg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string s = Console.ReadLine();

            Console.WriteLine($"Average = {Average(s)}");
        }
    }
}
