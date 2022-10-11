using System;

//The default parent class of any class is Object 

namespace Inheritance_in_Real_World_Example
{

    public class Program 
    {
        public static void Main(String[] args)
        {
            Teaching t = new(1, "mg", "Pune","Lecturer", "9876543210", 15000, "MSC", "math");
            t.getTeacher();
        }


    }
}