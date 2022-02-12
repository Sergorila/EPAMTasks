using System;
using SuperString.ExtensionMethod;

namespace SuperString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World! hfhпавп арбуз6456 алмаз 5345 камень-stone a-b";
            StringCheck check = new StringCheck(s);
            check.ShowTypes();

            check = new StringCheck("");
            check.ShowTypes();

            check = new StringCheck("..!?");
            check.ShowTypes();

        }
    }
}
