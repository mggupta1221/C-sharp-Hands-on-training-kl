using System;
using System.Drawing;
using System.Threading.Channels;

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

        public virtual void Method3()
        {
            Console.WriteLine("Base Method3");
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

            //use of base class pointer pointing to derived class is that
            //A derived class is a class which takes some properties from its base class.
            //It is true that a pointer of one class can point to other class, but classes must be a base and derived class, then it is possible.
            //To access the variable of the base class, base class pointer will be used.
            //So, a pointer is type of base class, and it can access all, public function and variables of base class since pointer is of base class, this is known as binding pointer.
            //In this pointer base class is owned by base class but points to derived class object.
           //Same works with derived class pointer, values is changed.

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
            bd.Method3();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("derived class instance caling methods");
            d.Method1(); //derived has method then why should it call super i.eit hides the method from base class and executes the own
            d.Method2();
        }
    }
}
    