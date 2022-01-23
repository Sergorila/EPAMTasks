using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities.Subjects
{
    public class Slime : Monster
    {
        public Slime()
        {
            Health = 20;
            Power = 5;
        }

        public override int Damage => Power;
    }
}
