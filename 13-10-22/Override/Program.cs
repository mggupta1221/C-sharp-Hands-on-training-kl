using System;

namespace Override
{
    public class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base Method2");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void Method1() //Hides the method and not override it
        {
            Console.WriteLine("Derived Method1");
        }
        public override void Method2() //Overrides the method
        {
            Console.WriteLine("Derived Method2");
        }


        public static void Main()
        {
            BaseClass b = new BaseClass();

            BaseClass bd = new DerivedClass();
            DerivedClass d=new DerivedClass();

            Console.WriteLine("Method1:No virtual and override keyword");
            Console.WriteLine("Method:Using virtual and override keyword");
            Console.WriteLine();



            Console.WriteLine("Base Class instance caling methods");
            b.Method1();
            b.Method2();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Base class instance refer to derived caling methods");
            bd.Method1();
            bd.Method2();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("derived class instance caling methods");
            d.Method1();
            d.Method2();
        }
    }
}
    