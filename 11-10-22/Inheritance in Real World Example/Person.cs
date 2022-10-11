using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_Real_World_Example
{
    public class Person
    {
        public int id;
        public string name, address, phone;

        public Person(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
}
