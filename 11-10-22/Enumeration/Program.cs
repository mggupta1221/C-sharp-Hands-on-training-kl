using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Enumeration
{

    public class Program
    {

        //private int a { set; get; } //setter getter for private members in c# many syntaxes are there for future reference link:https://www.w3schools.com/cs/cs_properties.php



        //Enum is Value type user defined datatype so it is declared in namespace,class or in structure

        //Syntax is
        //    [<modifiers>] enum <name>[:<type>]
        //    gives name to int value

        //public enum Days
        //{
        //    monday,
        //    Tuesday,
        //    wednesday,
        //    thursday,
        //    friday
        //};
        //static void Main(string[] args)
        //{
        //    Program p=new Program();

        //    Days d = 0;
        //    Console.WriteLine(d); //works fine for 0

        //    //Days d1 = 2;             //error 2(int cannot be converted to enum)
        //    Days d2 = (Days) 4;         //typecast the int to type enum works fine
        //    Console.WriteLine(d2);
        //}







        ////we can assign random values to it
        ////if we define only first value consecuatively next member number increamented by one
        ////default it will start from 0
        //public enum Days
        //{
        //    monday = 1,
        //    Tuesday,
        //    wednesday,
        //    thursday,
        //    friday
        //};
        //static void Main(string[] args)
        //{
        //    Program p = new Program();

        //    Days d = 0;
        //    Console.WriteLine(d); //for number which does not specified return number only

        //    //Days d1 = 2;             
        //    Days d2 = (Days)4;         
        //    Console.WriteLine(d2);
        //}






        //public enum Days
        //{
        //    monday = 1,
        //    Tuesday=22,
        //    wednesday=78,
        //    thursday=99,
        //    friday=23
        //};
        //static void Main(string[] args)
        //{
        //    Program p = new Program();

        //    Days d3 = Days.wednesday;
        //    //Console.WriteLine(d3); //prints wednesday
        //    //Console.WriteLine((int) d3); //prints78


        //    foreach (int i in Enum.GetValues(typeof(Days)))
        //    {
        //        Console.WriteLine(i+": "+(Days)i); //get values based on numbers like 1,22,23,78,99
        //    }
        //    Console.WriteLine();
        //    foreach (String i in Enum.GetNames(typeof(Days)))
        //    {
        //        Console.WriteLine(i);
        //    }


        //}



        //public enum Days:byte //supported types default:int byte short ushort long uint ulong sbyte
        //{
        //    monday = 1,
        //    Tuesday = 22,
        //    wednesday = 78,
        //    thursday = 99,
        //    friday = 23
        //};
        //static void Main(string[] args)
        //{ 


        //    foreach (byte i in Enum.GetValues(typeof(Days)))
        //    {
        //        Console.WriteLine(i + ": " + (Days)i); //get values based on numbers like 1,22,23,78,99
        //    }
        //    Console.WriteLine();
        //    foreach (String i in Enum.GetNames(typeof(Days)))
        //    {
        //        Console.WriteLine(i);
        //    }


        //}

        public enum Days
        {
            monday = 1,
            Tuesday = 22,
            wednesday = 78,
            thursday = 99,
            friday = 23
        };
        static void Main(string[] args)
        {
            Program p = new Program();

            Days d3 = Days.wednesday;
            //Console.WriteLine(d3); //prints wednesday
            //Console.WriteLine((int) d3); //prints78
            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i + ": " + (Days)i); //get values based on numbers like 1,22,23,78,99
            }
            Console.WriteLine();
            foreach (String i in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(i);
            }

        }
    }
}
