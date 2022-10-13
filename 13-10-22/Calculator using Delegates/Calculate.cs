using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_using_Delegates
{
    internal class Calculate
    {
        public delegate void CalculateDelegate(double x, double y);


        public void CalAdd(double x, double y)
        {
            Console.WriteLine("Addition :" + (x + y));
        }

        public void CalSubtract(double x, double y)
        {
            Console.WriteLine("Subtraction :" + (x - y));
        }

        public void CalMultiply(double x, double y)
        {
            Console.WriteLine("Multiplication :" + (x * y));
        }

        public void CalDivide(double x, double y)
        {
            Console.WriteLine("Division :" + (x / y));
        }

        public void CalRemainderOrModulus(double x, double y)
        {
            Console.WriteLine("Modulus :" + (x % y));
        }
    }
}
