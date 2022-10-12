//Exception is class which gets invoked when runtime error occurs which intern stops program abruptly


//so it is good to handle that exception so that rest of program can ececute

//it is handeled by using try catch finally
using System;
using System.Runtime.CompilerServices;

namespace Exception_Handeling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //contains risky code that can cause error+non risky code
            //    Console.WriteLine("Enter First Number");
            //    int firstNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number");
            //    int SecondNumber = int.Parse(Console.ReadLine());
            //    if (SecondNumber == 1) //for demonstration of use of finally block 
            //    {
            //        return;
            //    }

            //    int division=firstNumber/SecondNumber;
            //    Console.WriteLine($"Division:{division}");


            //}
            //catch (DivideByZeroException ex1)
            //{
            //    //what to do after exceptio occurs
            //    Console.WriteLine(ex1.Message);
            //}
            //catch(FormatException ex2)
            //{
            //    Console.WriteLine(ex2.Message);

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally //it will execute before return statement i.e always executes
            //{
            //    //cleanup code whic always executes whether exception occurs or not
            //    Console.WriteLine("Finally block Executed");
            //}
            //Console.WriteLine("End of program");



            //Appication Exception ; programmers shows exception
            Console.WriteLine("Enter First Number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber % 2 != 0)
            {
                //throw new ApplicationException("Divided by odd Number";
                throw new DeveloperDefinedExceptionDevidedByOddNumber();
            }
        }
    }
}