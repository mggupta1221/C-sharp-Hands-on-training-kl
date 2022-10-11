using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_Real_World_Example
{
    public class Staff : Person
    {
        public string designation = "";
        public int salary;
        public Staff(int id, string name, string address, string phone, string designation,int salary) : base(id, name, address, phone)
        {
            this.salary = salary;
            this.designation = designation;

        }



   

    }
}
