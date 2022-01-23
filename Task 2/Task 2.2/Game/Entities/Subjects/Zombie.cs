using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities.Subjects
{
    public class Zombie : Monster
    {
        public Zombie()
        {
            Health = 60;
            Power = 10;
        }

        public override int Damage => Power;
    }
}
