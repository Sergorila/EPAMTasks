using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString s1 = new CustomString(123, 3);
            s1.Show();

            s1.AddSymbol(0, 2, 'A');
            Console.WriteLine(s1.Length);
            s1.Show();

            s1.RemoveSymbol(0, 2);
            s1.Show();

            CustomString s2 = new CustomString("427");
            s1 = s1.Join(s2);
            s1.Show();

            CustomString s3 = new CustomString(121427, 6);
            Console.WriteLine(s3.Equals(s1));

            s3 = s3.Join(s1, 1);
            s3.Show();

            s3.AddSymbol('A');
            Console.WriteLine(s3.IndexOf('A'));

            s3.Replace(3, "bbb");
            s3.Show();

            CustomString s4 = new CustomString("5454");
            s4.Show();

            s4 = s4.Substring(0, 1);
            s4.Show();

            s3.CharUpper();
            s3.Show();
            s3.CharLower();
            s3.Show();
        }
    }
}
