using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray.ArrayExtensions
{
    public static class SuperInt
    {
        public delegate int IntAction(int param);

        public static int Pow2(int number) => number * number;

        public static int Divide(int number) => number / 2;

        public static void ApplyToMass(int[] mas, Func<int, int> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = func(mas[i]);
            }
        }

        public static int Sum(this int[] mas)
        {
            return mas.Sum(x => x);
        }

        public static double Average(this int[] mas)
        {
            return mas.Average(x => x);
        }

        public static int MostRepeat(this int[] mas)
        {
            Dictionary<int, int> repeat = new Dictionary<int, int>();
            
            foreach (var elem in mas)
            {
                if (repeat.ContainsKey(elem))
                {
                    repeat[elem]++;
                }
                else
                {
                    repeat[elem] = 1;
                }
            }

            int res = repeat.First(x => x.Value == repeat.Values.Max()).Key;
            return res;
        }
    }
}
