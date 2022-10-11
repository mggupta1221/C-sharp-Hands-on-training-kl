using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Parent1
    {
        //Parent1()
        //{
        //    Console.WriteLine("Private Parent1 COnstructor called");
        //}

        //parent class cannot access child class constructor

        public Parent1()
        {
            Console.WriteLine("public parent1 constructor called");
        }

        public Parent1(int number)
        {
            Console.WriteLine("public parent1 parameterized constructor called: "+number);
        }

        public void test1()
        {
            Console.WriteLine("Test 1 method");

        }

        public void test2()
        {
            Console.WriteLine("Test 2 method");

        }
    }
}
