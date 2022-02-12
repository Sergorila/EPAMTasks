using System;
using System.Collections;
using System.Collections.Generic;

namespace WEAKEST_LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;

            Console.Write("Введите количество людей: ");
            string input = Console.ReadLine();
            n = ValidChek(input);

            Console.Write("Введите удаляемый номер: ");
            input = Console.ReadLine();
            num = ValidChek(input);

            if (num > n)
            {
                throw new IndexOutOfRangeException("The delete-number must be less than the total number");
            }
            else
            {
                ListOfPersons list = new ListOfPersons(n);
                Console.WriteLine("Сгенерирован круг людей.");
                list.PrintList();
                Console.WriteLine($"Начинаем вычеркивать каждого {num}");
                list.ShowProcess(num);
                Console.WriteLine($"Игра окончена. Невозможно вычеркнуть больше людей.");
                Console.WriteLine("Номера победителей: ");
                list.PrintList();
            }
        }

        static int ValidChek(string input)
        {
            int res;
            if (int.TryParse(input, out res))
            {
                if (res < 0)
                {
                    throw new ArgumentException("Negative value");
                }
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }

            return res;
        }
    }
}
