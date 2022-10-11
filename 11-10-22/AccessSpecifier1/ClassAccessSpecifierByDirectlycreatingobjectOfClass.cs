//2.consuming member of class by non child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier1
{
    internal class ClassAccessSpecifierByDirectlycreatingobjectOfClass2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1();
            p.test2(); //private not accessible outside class
            p.test3(); //
            p.test4();
            p.test5();
        }
    }
}
