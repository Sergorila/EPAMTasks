using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Analysis
{
    public class Text
    {
        private string _text;
        private Dictionary<string, int> _words = new Dictionary<string, int>();
         

        public Text(string s)
        {
            char[] separators = new char[] { ',', '.', '!', '?', ';', ':', '"', '(', ')', ' ' };
            string[] helpWords = new string[] { "is", "are", "to", "the" };
            _text = s.Trim();
            string[] words = _text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                if (_words.ContainsKey(item) && !helpWords.Contains(item))
                {
                    _words[item]++;
                }
                else
                {
                    _words[item] = 1;
                }
            }
        }

        public void ShowStatistics()
        {
            foreach (var item in _words.OrderByDescending(item => item.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value} ({item.Value * 100 / _words.Count}%)");
            }
        }

        public int DiversityValue()
        {
            var values = _words.Values;
            int sum = 0;
            int usingWords = 0;
            foreach (var item in values.OrderByDescending(item => item))
            {
                sum += item;
                usingWords++;
                if (sum >= _words.Count/2)
                {
                    break;
                }
            }

            return usingWords;
        }

        public void GiveAnswer()
        {
            int count = DiversityValue();

            if (count < _words.Count/2)
            {
                Console.WriteLine("Good job! The text is diverse");
            }
            else
            {
                Console.WriteLine("Nah, The text isn't diverse :(");
            }
        }
    }
}
