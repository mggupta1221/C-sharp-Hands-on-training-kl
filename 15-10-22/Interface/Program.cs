//class: containe non abstractmethods (method with method body)|user defined datatype


//Abstract Class: containe non abstractmethods (method with method body)+ Abstract Methods(methods without method body)

//Interfaces: containsn only Abstract methods|user defined datatype|class can have interface as parent


//class default modifier is private    
//interface default modifier is public

//class default method  is non abstract
//Interface default method is abstract so we dont have to provide explixitely the abstract keyword

//class: we can define fields   |can creat reference of class using child class
//Interface: cant define fields |can create reference of interface using child class/interface


namespace Interface
{
    public interface Interface1
    {
        public void Test1();
        public void Test2();
    }

    public interface Interface2
    {
        public void Test1();
        public void Test2();
    }


    public class ImplementingInterfaces : Interface1, Interface2
    {
        public void Test1() // interface 1 and interface 2 not know anything about anyone so when we define same method present in interfaces it thinks the method is its own
        {
            Console.WriteLine("method common in both interfaces");
        }

         void Interface1.Test2() //explicit implementation
        { ////if u are defining the method in class using interface its name remove public
            Console.WriteLine("Interface1.Test2() called using ref of interface1 ");
        }

        void Interface2.Test2()
        { //if u are defining the method in class using interface its name remove public
            Console.WriteLine("Interface2.Test2() called using ref of interface2 ");
        }

    }

    public class CallInterfaces
    {
        public static void Main()
        {
            ImplementingInterfaces implementingInterfaces=new ImplementingInterfaces();
            Interface1 i1 = implementingInterfaces;
            Interface2 i2 = implementingInterfaces;

            Console.WriteLine("Derived");
            implementingInterfaces.Test1();
            //implementingInterfaces.Test2(); // error can be called using reference if interface
            Console.WriteLine();
            Console.WriteLine("Interface1 Reference:");
            i1.Test1();
            i1.Test2();
            Console.WriteLine();

            Console.WriteLine("Interface2 Reference:");
            i2.Test1();
            i2.Test2();

        }
    }
}

