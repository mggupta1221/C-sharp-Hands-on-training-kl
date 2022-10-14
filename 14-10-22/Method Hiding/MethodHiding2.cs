using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    public class Base
    {
        public virtual void Test1()
        {
            Console.WriteLine("Base test1");
        }

        public void Test2()
        {
            Console.WriteLine("Base test2");
        }

    }

    public class Derived:Base
    {

        public override void Test1()
        {
            Console.WriteLine("Derived test1");
        }


        public new void Test2() //Method Hiding/shadowing the new keyword says to base that i have implemented my own method and hide yours
        {
            Console.WriteLine("Derived test2");
        }
        public void ParentTest1()
        {
            base.Test1();
        }


        public void ParentTest2()
        {
            base.Test2();
        }

        public static void Main()
        {
            MethodHidingDerived md = new MethodHidingDerived();

            //---------------------------------------------------------------------------------------------------- 
            //if we want to call base methods from derived class  we can use 2 approaches
            //1.make parents object and call methods on it 
            //2.use base keyword in new methods and call it using derived classes object

            MethodHidingBase mbd = new MethodHidingDerived();
            mbd.Test1(); //overridden method from derived gets called
            mbd.Test2();

            //cannot use base keyword in static methods so make methods in derived and apply base keyword to it
            md.ParentTest1();
            md.ParentTest2();
            Console.WriteLine();





        }
    }


}
