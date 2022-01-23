using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities.Subjects
{
    public class Skeleton : Monster
    {
        public Skeleton()
        {
            Health = 60;
            Power = 20;
        }

        public override int Damage => Power;
    }
}
