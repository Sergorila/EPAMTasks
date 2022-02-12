using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperString.ExtensionMethod
{
    public class StringCheck
    {
        private string _s;
        private string[] _words;
        char[] _separators = new char[] { ',', '.', '!', '?', ';', ':', '"', '(', ')', ' ' };

        public StringCheck(string s)
        {
            _s = s;
           _words = _s.Trim().Split(_separators, StringSplitOptions.RemoveEmptyEntries);
        }

        private Types WordChek(string word)
        {
            if (word.Any(w => char.IsLetter(w)))
            {
                if (word.All(w => (w >= 'А' && w <= 'Я') || (w >= 'а' && w <= 'я')))
                {
                    return Types.Russian;
                }

                if (word.All(w => (w >= 'A' && w <= 'Z') || (w >= 'a' && w <= 'z')))
                {
                    return Types.English;
                }
            }
            
            if (word.All(w => char.IsDigit(w)))
            {
                return Types.Number;
            }

            return Types.Mixed;
        }

        public void ShowTypes()
        {
            if (_s == string.Empty)
            {
                Console.WriteLine("String is epmty.");
            }
            else
            {
                if (_words.Length == 0)
                {
                    Console.WriteLine($"{_s} - {Types.Mixed}");
                }
                
                foreach(var item in _words)
                {
                    Console.WriteLine($"{item} - {WordChek(item)}");
                }
            }
        }

        public enum Types
        {
            Russian = 1,
            English = 2,
            Number = 3,
            Mixed = 4,
            Empty = 5
        }
    }
}
