using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray.ArrayExtensions
{
    public static class SuperLong
    {
        public delegate long LongAction(long param);

        public static long Pow2(long number) => number * number;

        public static long Divide(long number) => number / 2;

        public static void ApplyToMass(long[] mas, Func<long, long> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = func(mas[i]);
            }
        }

        public static long Sum(this long[] mas)
        {
            return mas.Sum(x => x);
        }

        public static double Average(this long[] mas)
        {
            return mas.Average(x => x);
        }

        public static long MostRepeat(this long[] mas)
        {
            Dictionary<long, int> repeat = new Dictionary<long, int>();

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

            long res = repeat.First(x => x.Value == repeat.Values.Max()).Key;
            return res;
        }
    }
}
