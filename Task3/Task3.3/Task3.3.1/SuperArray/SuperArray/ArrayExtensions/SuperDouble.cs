using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray.ArrayExtensions
{
    public static class SuperDouble
    {
        public delegate double DoubleAction(double param);

        public static double Pow2(double number) => number * number;

        public static double Divide(double number) => number / 2;

        public static void ApplyToMass(double[] mas, Func<double, double> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = func(mas[i]);
            }
        }

        public static double Sum(this double[] mas)
        {
            return mas.Sum(x => x);
        }

        public static double Average(this double[] mas)
        {
            return mas.Average(x => x);
        }

        public static double MostRepeat(this double[] mas)
        {
            Dictionary<double, int> repeat = new Dictionary<double, int>();

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

            double res = repeat.First(x => x.Value == repeat.Values.Max()).Key;
            return res;
        }
    }
}
