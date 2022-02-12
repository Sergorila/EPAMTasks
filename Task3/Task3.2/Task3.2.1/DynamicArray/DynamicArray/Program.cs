using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            DynamicArray<int> arr2 = new DynamicArray<int>(3);
            arr.Add(6);
            arr.Add(8);
            arr.Add(7);

            Console.WriteLine(arr.Capacity);
            Console.WriteLine(arr.Count);

            arr.Insert(5, 1);

            arr.Remove(3);

            arr.AddRange(arr2);

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            arr.Capacity = 1;

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            DynamicArray<int> arr3 = new DynamicArray<int>();
            arr3.Add(9);
            arr3.Add(91);
            arr3.Add(911);
            arr3.Add(9111);
            Console.WriteLine(arr3[-2]);
        }
    }
}
