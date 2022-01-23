using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities.Subjects
{
    public class Lich : Monster
    {
        public Lich()
        {
            Health = 100;
            Power = 50;
        }

        public override int Damage => Power;
    }
}
