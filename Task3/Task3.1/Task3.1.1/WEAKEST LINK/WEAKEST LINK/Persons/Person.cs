using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEAKEST_LINK
{
    public class Person
    {
        public Person(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public Person NextPerson { get; set; }
    }
}
