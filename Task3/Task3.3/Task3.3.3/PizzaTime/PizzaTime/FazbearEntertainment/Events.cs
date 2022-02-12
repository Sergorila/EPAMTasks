using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.FazbearEntertainment
{
    public class Events : EventArgs
    {
        public int Number { get; init; }
        public Menu Pizza { get; init; }

        public Events(int number, Menu pizza)
        {
            Number = number;
            Pizza = pizza;
        }
    }
}
