using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interfaces;
using Game.Interfaces;
using Game.Entities.Map.Cells;

namespace Game.Entities.Subjects
{
    public abstract class Monster : ISubject, IMovable
    {
        private int _health;
        private int _power;
        
        public abstract int Damage { get; }

        public Cell Cell { get; set; } = new Cell();

        public int Health { get; set; } = 100;
        public int Power { get; set; } = 20;
        public void GetHeal(int val)
        {
            Health += val;
        }

        public void PowerUp(int val)
        {
            Power += val;
        }

        public void GetDamage(int val)
        {
            if (Health <= 0)
            {
                Health = 0;
            }
            else
            {
                Health -= val;
            }
        }

        public void Move(Cell cell, Material m)
        {
            //передвижение монстра
        }
    }
}
