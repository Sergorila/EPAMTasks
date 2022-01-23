using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Pie : Circle
    {
        public double Length
        {
            get
            {
                return base.Length;
            }
        }

        public double Square
        {
            get
            {
                return Math.PI * this.R * this.R;
            }
        }
        public Pie(Point center, double r)
            : base(center, r)
        {

        }

        public Pie(Circle c)
            : base(c.Center, c.R)
        {

        }

        public override string ToString()
        {
            return base.ToString() +
                $"Площадь: {Math.Round(this.Square, 2)}\n";
        }

        public override int Type()
        {
            return 3;
        }
    }
}
