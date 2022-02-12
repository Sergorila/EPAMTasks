using System;
using System.Collections;
using System.Collections.Generic;
using SuperArray.ArrayExtensions;

namespace SuperArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 4, 4};
            SuperInt.ApplyToMass(mas, SuperInt.Pow2);
            PrintMas(mas);
            Console.WriteLine(SuperInt.Average(mas));
            Console.WriteLine(SuperInt.MostRepeat(mas));

            double[] mas1 = { 1.1, 2.2, 3.3, 4.4 };
            SuperDouble.ApplyToMass(mas1, SuperDouble.Pow2);
            PrintMas(mas1);
        }

        public static void PrintMas<T>(T[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
