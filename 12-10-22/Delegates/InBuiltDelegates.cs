using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class InBuiltDelegates
    {
        public double AddFunc(int a, double b)
        {
            return (a + b);
        }
        public void AddAction(int a, double b,float c)
        {
            Console.WriteLine(a + b + c);
        }
        public bool GreaterThan1PredicateMethod(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public static void Main()
        {
            InBuiltDelegates i=new InBuiltDelegates();

            Func<int, double, double> funcObject = i.AddFunc;
            double funcResult = funcObject(1, 2.5);
            Console.WriteLine(funcResult);


            Action<int, double, float> actionDelegateObject = i.AddAction;
            actionDelegateObject(1, 2.5,1.3f);
  
            Predicate<int> predicateDelegateObject = i.GreaterThan1PredicateMethod;
            bool status = predicateDelegateObject(1);
            Console.WriteLine(status);

        }
    }


   
}
