using System;

namespace Array_Processing
{
    class Program
    {
        public static int FindMax(int[] arr)
        {
            int max = -101;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int FindMin(int[] arr)
        {
            int min = 101;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int Partition(int[] arr, int minIndex, int maxIndex)
        {
            int temp;
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (arr[i] < arr[maxIndex])
                {
                    pivot++;
                    temp = arr[pivot];
                    arr[pivot] = arr[i];
                    arr[i] = temp;
                }
            }

            pivot++;
            temp = arr[pivot];
            arr[pivot] = arr[maxIndex];
            arr[maxIndex] = temp;
            return pivot;
        }

        public static int[] QuickSort(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return arr;
            }

            var pivotIndex = Partition(arr, minIndex, maxIndex);
            QuickSort(arr, minIndex, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, maxIndex);

            return arr;
        }

        public static int[] QuickSort(int[] arr)
        {
            return QuickSort(arr, 0, arr.Length - 1);
        }

        public static void Show(int[] arr)
        {
            int max = FindMax(arr);
            int min = FindMin(arr);

            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");

            arr = QuickSort(arr);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Input()
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = Input();
            Show(arr);
        }
    }
}
