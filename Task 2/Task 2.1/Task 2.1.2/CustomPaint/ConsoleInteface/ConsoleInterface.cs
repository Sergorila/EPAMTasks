using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPaint.Entities;
using CustomPaint.Storage;

namespace CustomPaint.ConsoleInteface
{
    public static class ConsoleInterface
    {
        private static int _choose;
        public static void Menu()
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Показать все фигуры");
            Console.WriteLine("3. Удалить все фигуры");
            Console.WriteLine("4. Выйти из программы");
            string input = Console.ReadLine();
            bool valid = int.TryParse(input, out _choose); 
            if (valid)
            {
                switch(_choose)
                {
                    case 1:
                        AddFigure();
                        Console.WriteLine("Фигура создана");
                        Menu();
                        break;
                    case 2:
                        Console.WriteLine("Список фигур");
                        Show();
                        Menu();
                        break;
                    case 3:
                        Clear();
                        Console.WriteLine("Холст очищен");
                        Menu();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Выберите номер опции корректно!");
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите номер опции корректно!");
                Menu();
            }
        }

        static private void AddFigure()
        {
            Console.WriteLine("Выберите фигуру");
            Console.WriteLine("1. Линия");
            Console.WriteLine("2. Окружность");
            Console.WriteLine("3. Круг");
            Console.WriteLine("4. Кольцо");
            Console.WriteLine("5. Треугольник");
            Console.WriteLine("6. Прямоугольник");
            Console.WriteLine("7. Квадрат");

            FigureType fig;
            bool valid = FigureType.TryParse(Console.ReadLine(), out fig);
            if (valid)
            {
                switch(fig)
                {
                    case FigureType.Line:
                        Console.Write("Введите начальную точку через пробел: ");
                        string input = "";
                        input += Console.ReadLine() + " ";
                        Console.Write("Введите конечную точку через пробел: ");
                        input += Console.ReadLine();
                        string[] args = input.Split(' ');
                        double x1, y1, x2, y2;
                        try
                        {
                            valid = double.TryParse(args[0], out x1);
                            valid = double.TryParse(args[1], out y1);
                            valid = double.TryParse(args[2], out x2);
                            valid = double.TryParse(args[3], out y2);
                            ListOfFigures.AddFigure(new Line(x1, y1, x2, y2));
                        }
                        catch
                        {
                            Console.WriteLine("Введите координаты корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Circle:
                        Console.Write("Введите координаты центра окружности через пробел: ");
                        input = "";
                        input += Console.ReadLine() + " ";
                        Console.Write("Введите радиус окружности: ");
                        input += Console.ReadLine();
                        args = input.Split(' ');
                        double x, y, r;
                        try
                        {
                            valid = double.TryParse(args[0], out x);
                            valid = double.TryParse(args[1], out y);
                            valid = double.TryParse(args[2], out r);
                            if (r < 0)
                            {
                                Console.WriteLine("Радиус не может быть меньше нуля");
                                Menu();
                            }

                            ListOfFigures.AddFigure(new Circle(new Point(x, y), r));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Pie:
                        Console.Write("Введите координаты центра круга через пробел: ");
                        input = "";
                        input += Console.ReadLine() + " ";
                        Console.Write("Введите радиус круга: ");
                        input += Console.ReadLine();
                        args = input.Split(' ');
                        try
                        {
                            valid = double.TryParse(args[0], out x);
                            valid = double.TryParse(args[1], out y);
                            valid = double.TryParse(args[2], out r);
                            if (r < 0)
                            {
                                Console.WriteLine("Радиус не может быть меньше нуля");
                                Menu();
                            }

                            ListOfFigures.AddFigure(new Pie(new Point(x, y), r));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Ring:
                        Console.Write("Введите координаты центра кольца через пробел: ");
                        input = "";
                        input += Console.ReadLine() + " ";
                        Console.Write("Введите радиус внутренней окружности: ");
                        input += Console.ReadLine() + " ";
                        Console.Write("Введите радиус внешней окружности: ");
                        input += Console.ReadLine();
                        args = input.Split(' ');
                        double rOut;
                        try
                        {
                            valid = double.TryParse(args[0], out x);
                            valid = double.TryParse(args[1], out y);
                            valid = double.TryParse(args[2], out r);
                            valid = double.TryParse(args[3], out rOut);
                            if (r < 0 || rOut < 0)
                            {
                                Console.WriteLine("Радиус не может быть меньше нуля");
                                Menu();
                            }
                            if (rOut <= r)
                            {
                                Console.WriteLine("Внешний радиус должен быть больше внутреннего");
                                Menu();
                            }

                            ListOfFigures.AddFigure(new Ring(new Point(x, y), r, rOut));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Triangle:
                        Console.Write("Введите координаты вершин треугольника через пробел: ");
                        input = "";
                        input += Console.ReadLine();
                        args = input.Split(' ');
                        double x3, y3;
                        try
                        {
                            valid = double.TryParse(args[0], out x1);
                            valid = double.TryParse(args[1], out y1);
                            valid = double.TryParse(args[2], out x2);
                            valid = double.TryParse(args[3], out y2);
                            valid = double.TryParse(args[4], out x3);
                            valid = double.TryParse(args[5], out y3);

                            ListOfFigures.AddFigure(new Triangle(x1, y1, x2, y2, x3, y3));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Rectangle:
                        Console.Write("Введите координаты левой стороны через пробел: ");
                        input = "";
                        input += Console.ReadLine() + ' ';
                        Console.Write("Введите конечные координаты нижней стороны через пробел: ");
                        input += Console.ReadLine();
                        args = input.Split(' ');

                        try
                        {
                            valid = double.TryParse(args[0], out x1);
                            valid = double.TryParse(args[1], out y1);
                            valid = double.TryParse(args[2], out x2);
                            valid = double.TryParse(args[3], out y2);
                            valid = double.TryParse(args[4], out x3);
                            valid = double.TryParse(args[5], out y3);

                            ListOfFigures.AddFigure(new Rectangle(x1, y1, x2, y2, x3, y3));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    case FigureType.Quadrate:
                        Console.Write("Введите координаты стороны квадрата через пробел: ");
                        input = "";
                        input += Console.ReadLine();
                        args = input.Split(' ');
                        try
                        {
                            valid = double.TryParse(args[0], out x1);
                            valid = double.TryParse(args[1], out y1);
                            valid = double.TryParse(args[2], out x2);
                            valid = double.TryParse(args[3], out y2);

                            ListOfFigures.AddFigure(new Quadrate(x1, y1, x2, y2));
                        }
                        catch
                        {
                            Console.WriteLine("Введите параметры корректно!");
                            Menu();
                        }
                        break;
                    default:
                        Console.WriteLine("Выберите номер опции корректно!");
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите номер опции корректно!");
                Menu();
            }
            
        }

        private static void Show()
        {
            ListOfFigures.ShowFigures();
            Menu();
        }

        private static void Clear()
        {
            ListOfFigures.Clear();
            Menu();
        }

        enum FigureType
        {
            None = 0,
            Line = 1,
            Circle = 2,
            Pie = 3,
            Ring = 4,
            Triangle = 5,
            Rectangle = 6,
            Quadrate = 7
        }
    }
}
