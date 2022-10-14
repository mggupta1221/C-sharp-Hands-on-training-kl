using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    public class MethodHiding3Base
    {
        public virtual void Test1()
        {
            Console.WriteLine("MethodHiding3Base test1");
        }

        public void Test2()
        {
            Console.WriteLine("MethodHiding3Base test2");
        }

    }
    public class MethodHiding3Derived : MethodHiding3Base
    {
        public override void Test1()
        {
            Console.WriteLine("MethodHiding3Derived test1");
        }


        public new void Test2() //Method Hiding/shadowing the new keyword says to base that i have implemented my own method and hide yours
        {
            Console.WriteLine("MethodHiding3Derived test2");
        }

        public static void Main()
        {
            MethodHiding3Derived md = new MethodHiding3Derived();
            MethodHiding3Base m3b = md;



            MethodHidingBase mbd = new MethodHidingDerived();
            mbd.Test1(); //overridden method from derived gets called by using base class object referencing to derived class object
            mbd.Test2();

   





        }
    }


}
