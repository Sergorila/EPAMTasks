using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interfaces;

namespace Game.Entities.Map.Cells
{
    public class Trap : Material
    {
        private int _damage = 5;

        public override string Name => "Ловушка";

        public string Color => "Черный";

        public int Damage => _damage;

        public override bool IsMovable(ISubject obj)
        {
            //если кто-то наступит на эту клетку, то получит урон
            obj.GetDamage(Damage);
            return true;
        }
    }
}
