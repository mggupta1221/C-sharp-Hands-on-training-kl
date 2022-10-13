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
            DerivedClass d=new DerivedClass();
            d.Method1();
            d.Method2();
        }
    }
}
    