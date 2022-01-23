using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Triangle : Figure
    {
        private Line[] _lines = new Line[3];

        public double Length
        {
            get
            {
                return _lines[0].Length + _lines[1].Length + _lines[2].Length;
            }
        }

        public double Square
        {
            get
            {
                double p = this.Length / 2;
                return Math.Sqrt(p * (p - _lines[0].Length) * 
                    (p - _lines[1].Length) * (p - _lines[2].Length));

            }
        }

        public Triangle(Line l1, Line l2, Line l3)
        {
            if (l1.Length < l2.Length + l3.Length && l2.Length < l1.Length + l3.Length 
                && l3.Length < l1.Length + l2.Length)
            {
                this._lines[0] = l1;
                this._lines[1] = l2;
                this._lines[2] = l3;
            }
            else
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            : this(new Line(x1, y1, x2, y2), new Line(x2, y2, x3, y3), new Line(x3, y3, x1, y1))
            {

            }

        public override string ToString()
        {
            return $"Стороны треугольника:\n {_lines[0]} {_lines[1]} {_lines[2]}" +
                $"Периметр: {Math.Round(this.Length, 2)}\n" +
                $"Площадь: {Math.Round(this.Square, 2)}\n";
        }

        public override int Type()
        {
            return 5;
        }
    }
}
