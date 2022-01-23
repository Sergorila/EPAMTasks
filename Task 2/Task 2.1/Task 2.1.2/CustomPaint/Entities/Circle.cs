using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Circle : Figure
    {
        public double R { get; }

        public Point Center { get; }

        public Circle(Point center, double r)
        {
            this.Center = center;
            this.R = r;
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * this.R;
            }
        }

        public override string ToString()
        {
            return $"Центр: {this.Center}\n" +
                $"Внутренний радиус: {this.R}\n" +
                $"Длина: {this.Length}\n";
        }

        public override int Type()
        {
            return 2;
        }
    }
}
