using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Quadrate : Rectangle
    {
        public Quadrate(double x1, double y1, double x2, double y2)
            : this(new Line(x1, y1, x2, y2))
        {

        }

        public Quadrate(Line l)
            : base(l, l)
        {

        }

        public double Length { get; }

        public double Square { get; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int Type()
        {
            return 7;
        }
    }
}
