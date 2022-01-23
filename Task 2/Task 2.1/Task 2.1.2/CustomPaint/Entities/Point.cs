using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Point : Figure
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }

        public override int Type()
        {
            return 8;
        }
    }
}
