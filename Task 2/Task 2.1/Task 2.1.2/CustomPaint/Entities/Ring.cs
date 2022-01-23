using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Ring : Pie
    {
        public double ROut { get; }

        public Ring(Point center, double r, double rOut)
            : base(center, r)
        {
            this.ROut = rOut;
        }

        public Ring(Pie o, double rOut)
            : base(o.Center, o.R)
        {
            this.ROut = rOut;
        }

        public double Length
        {
            get
            {
                return base.Length + 2 * Math.PI * this.ROut;
            }
        }

        public double Square
        {
            get
            {
                return Math.PI * this.ROut * this.ROut - base.Square;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Внешний радиус: {this.ROut}";
        }

        public override int Type()
        {
            return 4;
        }
    }
}
