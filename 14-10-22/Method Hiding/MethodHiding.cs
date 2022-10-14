using System;
using System.Security.Cryptography.X509Certificates;

namespace Method_Hiding
{
    public class MethodHidingBase{
        public virtual void Test1()
        {
            Console.WriteLine("Base test1");
        }

        public void Test2()
        {
            Console.WriteLine("Base test2");
        }




    }

    public class MethodHidingDerived:MethodHidingBase
    {
        public override void Test1()
        {
            Console.WriteLine("Derived test1");
        }


        public new void Test2() //Method Hiding/shadowing
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
            MethodHidingDerived md=new MethodHidingDerived();
            //MethodHidingBase mb=new MethodHidingBase();
            //MethodHidingBase mbd = new MethodHidingDerived();

            md.Test1();
            md.Test2();
            Console.WriteLine();

        }
    }




}