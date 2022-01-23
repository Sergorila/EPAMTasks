using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interfaces;

namespace Game.Entities.Map.Cells
{
    public abstract class Material
    {
        public abstract string Name { get; }

        public abstract bool IsMovable(ISubject obj);
    }
}
