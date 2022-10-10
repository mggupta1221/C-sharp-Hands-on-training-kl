
// https://www.geeksforgeeks.org/c-sharp-data-types/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
   public class DatatypesInCSharp
    {


        int nnsttic = 10;
        static int sttic = 20;
        const int CONSTANTVARIABLE = 20;
        readonly bool ro;

        static void main(string[] args)
        {
            //Console.WriteLine(nnsttic);// gives error as non static members are not directly accessed in static method
            //as memory is allocated to nnsttic only if the object are created

            //Console.WriteLine(sttic); // no error as sttic is static and static variables are initialized once the execuation starts
            //Console.WriteLine(CONSTANTVARIABLE);


            //DatatypesInCSharp d=new DatatypesInCSharp(); //created copy (instance) of class DatatypesInCsharp (class is intantiated) to access non static member of class
            //create instance of class always using new keyword
            //Console.WriteLine(d.nnsttic);

            //DatatypesInCSharp d; //error use of unassigned local variable // now d is not an instance but a variable type

            // Creating an instance of class
            //1. DatatypesInCSharp d1=new DatatypesInCSharp();
            //2.DatatypesInCSharp d2;
            //   d2 = new DatatypesInCSharp(); 

            //int number = 9;
            //number = "ASDF"; //Error due to typesafety c# is strongly typed language

            //diffrent kinds of variable
            //    static: initialized only once in lifecycle of class initialized by constructor or not using constructor

            //    non static:initialized 0 or n times if called n time s | to use it is MultilineStringConverter to creat an object of class

            //    constant: initialized only once in lifecycle of class cannot be modified creared using "const" keyword;

            //only diffrence b/while static and constant is static variable can be modified

            //   readonly:  after initialization cannot be ,modified
            //new copies for n objects but can be given value only once
            //DatatypesInCSharp d1 = new DatatypesInCSharp(false);
            //d1.ro = true;//error

            //Datatypes
            //    Value datatype              reference Datatype          pointer datatype
            //    bool                           String
            //    byte                           Object
            //    short
            //    int     
            //    long
            //    Float
            //    double
            //    char
               
            



        }

    }
}
