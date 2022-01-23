using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Cell
    {
        private int _x;
        private int _y;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                if (_x > Field.Width - 1)
                {
                    _x = Field.Width - 1;
                }
                if (_x < 0)
                {
                    _x = 0;
                }
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                if (_y > Field.Height - 1)
                {
                    _y = Field.Height - 1;
                }
                if (_y < 0)
                {
                    _y = 0;
                }
            }
        }
    }
}
