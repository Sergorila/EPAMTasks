using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.FazbearEntertainment
{
    public static class Table
    {
        private static int _pos = 1;

        public static event Action<int, Menu> StartMaking;

        public static event Action TakeAnOrder = () => { };

        public static void MakeAnOrder(Menu pizza)
        {
            Console.WriteLine($"The order with the number {_pos} is accepted. Start making {pizza} pizza.");
            Pizzeria.Complete += Ready;
            StartMaking.Invoke(_pos, pizza);
            _pos++;
        }

        public static void Ready(object sender, Events events)
        {
            Console.WriteLine($"The order with the number {events.Number} is ready! Please pick up the order.");
            Pizzeria.Complete -= Ready;
            TakeAnOrder.Invoke();
        }
    }
}
