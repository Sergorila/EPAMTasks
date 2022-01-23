using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interfaces;

namespace Game.Entities.Map.Cells
{
    public class Road : Material
    {
        public override string Name => "Путь";

        public string Color => "Коричневый";

        public override bool IsMovable(ISubject obj)
        {
            //Игрок всегда может идти по обычному пути, без препятствий
            return true;
        }
    }
}
