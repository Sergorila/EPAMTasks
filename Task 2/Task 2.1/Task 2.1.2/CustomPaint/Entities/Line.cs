using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public class Line : Figure
    {
        private Point _start;
        private Point _end;

        public Point Start { get; set; }

        public Point End { get; set; }

        public Line(double x1, double y1, double x2, double y2)
            : this(new Point(x1, y1), new Point(x2, y2))
        {

        }

        public Line(Point _start, Point _end)
        {
            this._start = _start;
            this._end = _end;
        }

        public double Length
        {
            get
            {
                return Math.Round(Math.Sqrt((_end.X - _start.X) * (_end.X - _start.X) +
                    (_end.Y - _start.Y) * (_end.Y - _start.Y)), 2);
            }
        }

        public override string ToString()
        {
            return $"{_start} -> {_end}\n" +
                $"Длина: {this.Length}\n";
        }

        public override int Type()
        {
            return 1;
        }
    }
}
