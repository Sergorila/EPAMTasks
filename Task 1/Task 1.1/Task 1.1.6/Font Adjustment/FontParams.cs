using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font_Adjustment
{
    class FontParams
    {
        public List<string> parameters;

        public FontParams()
        {
            parameters = new List<string>();
        }
        public void Show()
        {
            Console.Write("Параметры надписи: ");
            if (parameters.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < parameters.Count - 1; i++)
                {
                    Console.Write($"{parameters[i]}, ");
                }
                Console.WriteLine($"{parameters[parameters.Count - 1]}");
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
                    if (parameters.Contains("Bold"))
                    {
                        parameters.Remove("Bold");
                    }
                    else
                    {
                        parameters.Add("Bold");
                    };
                    break;
                case 2:
                    if (parameters.Contains("Italic"))
                    {
                        parameters.Remove("Italic");
                    }
                    else
                    {
                        parameters.Add("Italic");
                    };
                    break;
                case 3:
                    if (parameters.Contains("Underline"))
                    {
                        parameters.Remove("Underline");
                    }
                    else
                    {
                        parameters.Add("Underline");
                    };
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            parameters.Sort();
            Show();
        }
    }
}
