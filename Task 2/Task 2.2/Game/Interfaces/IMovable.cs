using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.Entities.Map.Cells;

namespace Game.Interfaces
{
    public interface IMovable
    {
        Cell Cell { get; }

        void Move(Cell cell, Material m);
    }
}
