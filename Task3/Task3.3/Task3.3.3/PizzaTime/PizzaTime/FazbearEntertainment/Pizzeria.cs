using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.FazbearEntertainment
{
    public static class Pizzeria
    {
        public static void MakeAnOrder(int ID, Menu pizza)
        {
            Preparing(ID, pizza);
        }

        private static void Preparing(int ID, Menu pizza)
        {
            System.Threading.Thread.Sleep(3000);
            Ready(ID, pizza);
        }

        public static event EventHandler<Events> Complete;

        private static void Ready(int ID, Menu pizza)
        {
            Complete.Invoke(null, new Events(ID, pizza));
        }
    }
}
