//https://www.youtube.com/watch?v=aAEcoKYwD8I&list=PLVlQHNRLflP-jc5Fbhfdhzv52AWYq836j&index=8&ab_channel=NareshiTechnologies
using System;

namespace AccessSpecifier1
{
    //class can only be internal and public and default class modifier is internal

    public class Program
    {
        public void test1()
        {
            Console.WriteLine("public test1");
        }

        private void test2()
        {
            Console.WriteLine("Private test2");
        }

        protected void test3()
        {
            Console.WriteLine("protected test3");
        }

        internal void test4()
        {
            Console.WriteLine("internal test4");
        }

        protected internal void test5()
        {
            Console.WriteLine("protected internal test5");
        }

   
        static void Main(string[] args)
        {
            Program p= new Program(); // within class all are accessible
            p.test1();
            p.test2();  
            p.test3();
            p.test4();
            p.test5();
        }
    }
}