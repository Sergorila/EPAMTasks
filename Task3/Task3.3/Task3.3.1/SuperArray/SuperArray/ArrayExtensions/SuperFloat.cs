using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray.ArrayExtensions
{
    public static class SuperFloat
    {
        public delegate float FloatAction(float param);

        public static float Pow2(float number) => number * number;

        public static float Divide(float number) => number / 2;

        public static void ApplyToMass(float[] mas, Func<float, float> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = func(mas[i]);
            }
        }

        public static float Sum(this float[] mas)
        {
            return mas.Sum(x => x);
        }

        public static float Average(this float[] mas)
        {
            return mas.Average(x => x);
        }

        public static float MostRepeat(this float[] mas)
        {
            Dictionary<float, int> repeat = new Dictionary<float, int>();

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

            float res = repeat.First(x => x.Value == repeat.Values.Max()).Key;
            return res;
        }
    }
}
