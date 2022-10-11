//1.Consuming members of class from child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public class ClassAccessSpecifierInheritance1:Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); 
            ClassAccessSpecifierInheritance1 c =new ClassAccessSpecifierInheritance1();
            p.test1();
            c.test1();
            p.test2(); //private not accessible by inheritance in child class
            c.test2(); //private not accessible by inheritance in child class

            p.test3(); //
            c.test3(); //by chld class object protected is accessible 

            p.test4();
            c.test4();

            p.test5();
            c.test5();
        }
    }
}
