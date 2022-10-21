using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_methods
{
    public abstract class Abstract2
    {

        public void Add(int x,int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }
        public abstract void Mul(int x, int y);
        public abstract void div(int x, int y);

    }

    public class DerivedAbstract2:Abstract2
    {
        public static void Main()
        {
            DerivedAbstract2 d=new DerivedAbstract2();

            Abstract2 a = d; //abstract method instance cannot be created but reference can be creacted that reference can call overridden methods of abstract parent class

            d.Mul(1,2);
            d.div(1,2);
            d.Add(1,2);
            d.Sub(1,2);
            Console.WriteLine("Using Parent abstract reference:");
            a.Mul(1, 2);
            a.div(1, 2);
            a.Add(1, 2);
            a.Sub(1, 2);

        }

        public override void div(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }
    }

}
