using System;
namespace Overloading_vs_Overriding
{

    public class Program
    {
        public void MethodToBeOverloaded (string str)
        {
            Console.WriteLine("parameter:string");
        }

        public void MethodToBeOverloaded(string str,int num1)
        {
            Console.WriteLine("parameter:string,int");
        }
        public void MethodToBeOverloaded(int num1,string str)
        {
            Console.WriteLine("parameter:int,str");
        }

        public void MethodToBeOverloaded()
        {
            Console.WriteLine("parameter:");
        }
        public void MethodToBeOverloaded(int num1)
        {
            Console.WriteLine("parameter:int");
        }


        public  void MethodToBeOverriddenWithoutVirtual() //method cannot be overridden if the parent method is not virtual
        {
            Console.WriteLine("Parent Method no virtual");
        }


        public virtual void MethodToBeOverriddenWithVirtual() //this method is overridden if the child class method has override keyword
        {
            Console.WriteLine("Parent Method virtual used");
        }

        //public static void Main() //overloading can be done in same class or in base class
        //{
        //    Program p = new Program();
        //    p.MethodToBeOverloaded();
        //    p.MethodToBeOverloaded(5);
        //    p.MethodToBeOverloaded("HELLO");
        //    p.MethodToBeOverloaded("HELLO", 5);
        //    p.MethodToBeOverloaded(5,"Hello");
        //}


    }

    public class ChildProgram : Program
    {

        public void MethodToBeOverloaded(int num1, double num2)
        {
            Console.WriteLine("Child Method parameter:int,double");
        }

        public override void MethodToBeOverriddenWithVirtual() //Overridden Method
        {
            Console.WriteLine("Child Method virtual And override used");
        }


        public void MethodToBeOverriddenWithoutVirtual()
        {
            Console.WriteLine("Child Method no virtual");
        }
        public static void Main()
        {
            Program p = new Program();
            BaseProgram b=new BaseProgram();

            b.MethodToBeOverloaded();
            b.MethodToBeOverloaded(5);
            b.MethodToBeOverloaded("hello");
            b.MethodToBeOverloaded("hello", 5);
            b.MethodToBeOverloaded(5, "hello");
            b.MethodToBeOverloaded(5, 3.2);

            Console.WriteLine();

            b.MethodToBeOverriddenWithVirtual();
            p.MethodToBeOverriddenWithVirtual();
            b.MethodToBeOverriddenWithoutVirtual();
            p.MethodToBeOverriddenWithoutVirtual();






        }
    }



}
