using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities.Subjects;

namespace Game.Entities.Map.Items
{
    public class GoldenApple : Item
    {
        private int _heal = 5;

        public GoldenApple(Cell cell)
            : base(cell)
        {

        }

        public override int ItemValue => _heal;

        public override void UseItem(Player p)
        {
            p.GetHeal(ItemValue);
            p.Items += 1;
        }
    }
}
