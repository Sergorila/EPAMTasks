using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities.Subjects;

namespace Game.Entities.Map.Items
{
    public class DimondSword : Item
    {
        private int _power = 10;

        public DimondSword(Cell cell)
            : base(cell)
        {

        }

        public override int ItemValue => _power;

        public override void UseItem(Player p)
        {
            p.PowerUp(ItemValue);
            p.Items += 1;
        }
    }
}
