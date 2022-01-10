using System;
using System.Text;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string s = Console.ReadLine();

            Console.WriteLine("Result text");
            Console.WriteLine(Validator(s));
        }

        public static StringBuilder Validator(string s)
        {
            string sep = ".!?";

            string[] words = s.Split(' ');

            bool isUpperSymbol = true;

            for (int i = 0; i < words.Length; i++)
            {
                if (isUpperSymbol)
                {
                    if (words[i].Length > 1)
                    {
                        words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1);
                    }
                    else
                    {
                        words[i] = words[i].ToUpper();
                    }

                    isUpperSymbol = false;
                }

                if (sep.Contains(words[i][words[i].Length - 1]))
                {
                    isUpperSymbol = true;
                }
                
            }

            StringBuilder res = new StringBuilder("");
            foreach (var word in words)
            {
                res.Append(word);
                res.Append(" ");
            }

            return res;
        }
    }
}
