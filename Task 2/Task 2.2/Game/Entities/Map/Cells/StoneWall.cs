using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interfaces;

namespace Game.Entities.Map.Cells
{
    public class StoneWall : Material
    {
        public override string Name  => "Каменная стена";

        public string Color => "Серый";

        public override bool IsMovable(ISubject obj)
        {
            //игрок не может пойти на клетку, где стена
            return false;
        }
    }
}
