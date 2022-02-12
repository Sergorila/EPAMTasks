using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray.ArrayExtensions
{
    public static class SuperDecimal
    {
        public delegate decimal DecimalAction(decimal param);

        public static decimal Pow2(decimal number) => number * number;

        public static decimal Divide(decimal number) => number / 2;

        public static void ApplyToMass(decimal[] mas, Func<decimal, decimal> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = func(mas[i]);
            }
        }

        public static decimal Sum(this decimal[] mas)
        {
            return mas.Sum(x => x);
        }

        public static decimal Average(this decimal[] mas)
        {
            return mas.Average(x => x);
        }

        public static decimal MostRepeat(this decimal[] mas)
        {
            Dictionary<decimal, int> repeat = new Dictionary<decimal, int>();

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

            decimal res = repeat.First(x => x.Value == repeat.Values.Max()).Key;
            return res;
        }
    }
}
