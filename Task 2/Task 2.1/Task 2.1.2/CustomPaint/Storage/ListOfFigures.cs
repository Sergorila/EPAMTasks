using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPaint.Entities;

namespace CustomPaint.Storage
{
    public static class ListOfFigures
    {
        private static List<Figure> _figures = new List<Figure>();

        public static void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }

        public static void Clear()
        {
            _figures.Clear();
        }

        public static void ShowFigures()
        {
            if (_figures.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            foreach (var fig in _figures)
            {
                switch ((FigureType)fig.Type())
                {
                    case FigureType.Line:
                        Console.WriteLine("Линия");
                        break;
                    case FigureType.Circle:
                        Console.WriteLine("Окружность");
                        break;
                    case FigureType.Pie:
                        Console.WriteLine("Круг");
                        break;
                    case FigureType.Ring:
                        Console.WriteLine("Кольцо");
                        break;
                    case FigureType.Triangle:
                        Console.WriteLine("Треугольник");
                        break;
                    case FigureType.Rectangle:
                        Console.WriteLine("Прямоугольник");
                        break;
                    case FigureType.Quadrate:
                        Console.WriteLine("Квадрат");
                        break;
                }
                Console.WriteLine(fig + "\n");
            }
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
