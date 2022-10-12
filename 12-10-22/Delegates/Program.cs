using System;
using static Delegates.Program;
//Delegates are pointers to a method which are type safe 
//whole method is passed as parameter to delegate reference //just like higher order function
namespace Delegates
{
    public class Program
    {

        public delegate void addDelegate(int num1,int num2);

        public delegate string sayDelegate(string name);

        public void addNumbers(int number1,int number2)
        {
            Console.WriteLine("Addition is:" + (number1 + number2));

        }

        public static string sayHello(string naam)
        {
            return "Hello " + naam;
        }

        public static void Main()
        {
            Program p = new Program();
            addDelegate delegateAdd = new addDelegate(p.addNumbers); // addnumber is not static so it is called by using its object
            sayDelegate delegateSay = new sayDelegate(Program.sayHello); //sayhello

            delegateAdd(2, 3);//or 
            delegateAdd.Invoke(55, 100);
            String greeting1=delegateSay("Mukesh");
            String greeting2 = delegateSay.Invoke("Mukesh");

            Console.WriteLine(greeting1);
            Console.WriteLine(greeting2);
        }
    }
}