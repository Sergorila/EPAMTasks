using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Rectangle : Figure
    {
        public Line A { get; }
        public Line B { get; }

        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3)
            : this(new Line(new Point(x1, y1), new Point(x2, y2)), new Line(new Point(x1, y1), new Point(x3, y3)))
        {

        }

        public Rectangle(Line l1, Line l2)
        {
            this.A = l1;
            this.B = l2;
        }

        public double Length
        {
            get
            {
                return 2 * (A.Length + B.Length);
            }
        }

        public double Square
        {
            get
            {
                return A.Length * B.Length;
            }
        }

        public override string ToString()
        {
            return $"Длины сторон: \n" +
                $"{A.Length} {B.Length}\n" +
                $"Периметр: {this.Length}\n" +
                $"Площадь: {this.Square}";
        }

        public override int Type()
        {
            return 6;
        }
    }
}
