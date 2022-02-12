using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.FazbearEntertainment
{
    public class User
    {
        public int ID { get; init; }

        public User(int id)
        {
            ID = id;
        }
        public void MakeAnOrder(Menu pizza)
        {
            Table.TakeAnOrder += Take;
            Table.MakeAnOrder(pizza);

        }

        private void Take()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine($"Client №{ID} has picked up the order.");
            Table.TakeAnOrder -= Take;
        }
    }
}
