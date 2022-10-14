using System;


//sealed classes used if u dont want anyone to derive from your class
//eg ui component 

namespace Sealed_Class
{

    sealed class SealedClass
    {
        
    }

    //public class SimpleClass : SealedClass { } //Error cannot derive from sealed class

    public class SimpleClass
    {
        public void Test1()
        {
            Console.WriteLine("simple class test1");
        }

        public virtual void Test2()
        {
            Console.WriteLine("simple class virtual test2");
        }

    }

    public class DerivedSimpleClass : SimpleClass
    {
        public override sealed void Test2() // u can override and make base method sealed
        {
            //sealed method cannot be overridden
        }


    }
}
    
    
