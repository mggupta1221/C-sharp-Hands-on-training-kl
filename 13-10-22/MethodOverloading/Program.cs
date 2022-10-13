using System;
//use of overloading
//based on polymorphism:changing behaviour based on inputs ||same name diffrent implementation || static binding

namespace MethodOverloading
{
    public class Program
    {

        public void test() 
        {
            Console.WriteLine("test1");
        }
        public void test(int i)
        {
            Console.WriteLine("test2");
        }
        public void test(string s)
        {
            Console.WriteLine("test3");
        }
        public void test(int i, string s)
        {
            Console.WriteLine("test4");
        }
        public void test(string s, int i)
        {
            Console.WriteLine("test5");
        } // all 5 are valid

        //public string test() { }//changing return type does not implement overloading



        public static void Main()
        {
            Program p=new Program();
            p.test();
            p.test(3);
            p.test("abs");
            p.test(1, "str1");
            p.test("str2", 5);
        }







    }
}