using System;
//indexers used to access class members through indexing


using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    public class Indexer
    {
        public int Id { get;}
        public string Name { get;}

        public string Department { get;}
        public int Salary { get; }

        public Indexer(int id,string name,string department,int salary)
        {
                this.Id = id;   
             this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }


        public object this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return Id;
                }
                else if (index == 2)
                {
                    return Name;
                }
                else if (index == 3)
                {
                    return Department;
                }
                else if (index == 4)
                {
                    return Salary;
                }
                return null;

            }

        }


    }
}
