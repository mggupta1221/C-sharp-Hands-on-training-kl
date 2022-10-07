using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nit
{
    internal class TypesOfConstructor
    {

        //parameterless/default impicit or explicit
        //they are either defined by programmer or compiler


        //parameterized explicit
        //if a constructor method is defined with out any parameters we call
        //that as parameterized constructor and these constructors can be
        //defined by the programmers only but never can be defined implicitly.|
        public typesofconstructor(int i, int j)
        {
            console.writeline("explicit constructor called values are i=" + i + "j=" + j);
        }

        static void main(string[] a)
        {
            typesofconstructor e = new typesofconstructor(10, 20);
        }



        //copy constructor
        //passing object of same class as a parameter
        //        if we want to create multiple instances with the same values then we
        //use these copy constructors, in a copy constructor the constructor
        //takes the same class as a paramter to it.

        int x;
        public typesofconstructor(typesofconstructor t2)
        {
            x = t2.x;          // x=value at 2.x i.e value of t1.x
            console.writeline("copy constructor called values are x=" + x);
        }

        public typesofconstructor(int i)
        {
            x = i;
            console.writeline("parameterized constructor called values are x=" + x);
        }


        static void main(string[] a)
        {
            typesofconstructor t1 = new typesofconstructor(10);
            typesofconstructor t = new typesofconstructor(t1);
        }




        //static constructor
        //          if a class contains any static variables then only implicit static
        //          constructors will be present or else we need to define them
        //          explicitly whereas non-static constructors will be implicitly defined
        //          in every class (except static class) provided we did not define them
        //          explicitly.

        //           2.if a constructor is explicitly declared by using static modifier we
        //          call that as static constructor.
        //static constructor are responsible in initializing static
        //variables and these constructors are never called explicitly they are
        //implicitly called and more over these constructor are first to
        //execute under any class.
        //

        //            3. static constructors can't be parameterized so overloading static
        //            constructors is not possible.|



        static TypesOfConstructor()
        {
            Console.WriteLine("Static constructor is executed.");

        }

        static void Main()
        {
            Console.WriteLine("Main method is executed.");

        }
        //output is Static constructor is executed
        //main method is executed






    }
}
