using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font_Adjustment
{
    class FontParams
    {
        public Dictionary<string, bool> parameters;

        public FontParams()
        {
            parameters = new Dictionary<string, bool>();
            parameters["Bold"] = false;
            parameters["Italic"] = false;
            parameters["Underline"] = false;
        }
        public void Show()
        {
            Console.Write("Параметры надписи: ");
            int count = 0;
            foreach (var item in parameters.Keys)
            {
                if (parameters[item])
                {
                    Console.Write($"{item} ");
                    count++;
                }       
            }
            if (count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine("Введите: ");
            Console.WriteLine($"\t1: bold");
            Console.WriteLine($"\t2: italic");
            Console.WriteLine($"\t3: underline");
            ChangeParameter();
        }
        public void ChangeParameter()
        {
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    if (parameters["Bold"])
                    {
                        parameters["Bold"] = false;
                    }
                    else
                    {
                        parameters["Bold"] = true;
                    };
                    break;
                case 2:
                    if (parameters["Italic"])
                    {
                        parameters["Italic"] = false;
                    }
                    else
                    {
                        parameters["Italic"] = true;
                    };
                    break;
                case 3:
                    if (parameters["Underline"])
                    {
                        parameters["Underline"] = false;
                    }
                    else
                    {
                        parameters["Underline"] = true;
                    };
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            Show();
        }
    }
}
