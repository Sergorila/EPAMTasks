using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sides of the rectangle");
            Console.Write("a = ");
            int a, b;
            if (!int.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            
            Console.Write("b = ");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (a > 0 && b > 0)
            {
                Console.WriteLine($"S = {a * b}");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
