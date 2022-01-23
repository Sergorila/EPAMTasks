using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities.Subjects;

namespace Game.Entities.Map.Items
{
    public abstract class Item
    {
        public Item(Cell cell)
        {
            Index = cell;
        }

        public abstract int ItemValue { get; }
        public Cell Index { get; }

        public abstract void UseItem(Player p);
    }
}
