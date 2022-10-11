using System;

//The default parent class of any class is Object 

namespace Inheritance
{

    public class Program:Parent1
    { 
            Program(int a):base(a)
            {
                Console.WriteLine("Child Constructor called");
            }
            static void Main(string[] args)
            {
                Program c = new Program(55); //implicitely go to parent constuctor calls it then calles own constructor
                c.test1();
                c.test2();   
            }

       
    }
}