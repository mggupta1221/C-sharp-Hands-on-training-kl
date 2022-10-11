using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_Real_World_Example
{
    public class NonTeaching : Staff
    {
        public string dName = "";
        public string mgrId = "";
        public NonTeaching(int id, string name, string address, string phone, string designation, int salary, string dName, string mgrId) : base(id, name, address, phone, designation, salary)
        {
            this.dName = dName;
            this.mgrId = mgrId;
        }


    }
}
