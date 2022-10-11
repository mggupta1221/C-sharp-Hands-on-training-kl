using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_Real_World_Example
{
    public class Teaching : Staff
    {
        public string qualification = "";
        public string subject = "";

        public Teaching(int id, string name, string address, string phone, string designation, int salary, string qualification, string subject) : base(id, name, address, phone, designation, salary)
        {
            this.qualification = qualification;
            this.subject = subject;
        }

        public void getTeacher()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("name:" + name);

            Console.WriteLine("address:" + address);
            Console.WriteLine("phone:" + phone);
            Console.WriteLine("designation:" + designation);
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("qualification:" + qualification);
            Console.WriteLine("subject:" + subject);
            Console.WriteLine("qualification:" + qualification);
            Console.WriteLine("subject:" + subject);

        }



    }
}
