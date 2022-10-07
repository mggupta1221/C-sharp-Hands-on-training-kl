//Video Link: https://www.youtube.com/watch?v=Fo_SED11gME&list=PLVlQHNRLflP-jc5Fbhfdhzv52AWYq836j&index=4&ab_channel=NareshiTechnologies
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nit
{
    internal class ExplicitConstructorDemo
    {
        //Defining a Constructor: either impicit or explicit
        public ExplicitConstructorDemo()
        {
            Console.WriteLine("Explicit Constructor called");
        }

        static void main(string[] a)
        {
            ExplicitConstructorDemo e = new ExplicitConstructorDemo();//Calling a Constructor always explicit
        }
    }

}
