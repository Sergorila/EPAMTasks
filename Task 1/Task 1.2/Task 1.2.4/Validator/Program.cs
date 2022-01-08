using System;
using System.Text;

namespace Validator
{
    class Program
    {
        public static string Validator(string s)
        {
            string sep = ".!?";

            string temp = s;
            for (int i = 0; i < temp.Length; i++)
            {
                if (sep.Contains(temp[i]))
                {
                    temp = temp.Insert(i + 1, "+");
                }
            }

            string[] words = temp.Split('+');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if (words[i].Length > 1)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1);
                }
                else
                {
                    words[i].ToUpper();
                }
            }

            string res = "";
            foreach (var word in words)
            {
                res += word;
                res += " ";
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string s = Console.ReadLine();

            Console.WriteLine("Result text");
            Console.WriteLine(Validator(s));
        }
    }
}
