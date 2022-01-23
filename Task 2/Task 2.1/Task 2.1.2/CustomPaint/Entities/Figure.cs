using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Entities
{
    public abstract class Figure
    {
        public virtual double Length { get; init; }

        public abstract int Type();
    }
}
