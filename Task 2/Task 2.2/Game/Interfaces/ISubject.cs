using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface ISubject
    {
        int Health { get; }
        int Power { get; }

        void PowerUp(int val);
        
        void GetDamage(int val);

        void GetHeal(int val);
    }
}
