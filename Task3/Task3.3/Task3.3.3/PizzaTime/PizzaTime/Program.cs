using System;
using PizzaTime.FazbearEntertainment;
using System.Collections.Generic;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> lst = new List<User>();
            for (int i = 500; i < 505; i++)
            {
                lst.Add(new User(i));
                
            }

            Table.StartMaking += Pizzeria.MakeAnOrder;
            int j = 1;
            foreach (var user in lst)
            {
                user.MakeAnOrder((Menu)j);
                j++;
            }
            
        }
    }
}
