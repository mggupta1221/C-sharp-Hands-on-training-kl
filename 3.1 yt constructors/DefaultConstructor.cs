using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nit
{
    public class DefaultConstructor
    {
        public int a; 
        public string? s;
        public bool b;


        //1.Constructor implicit
        static void main(string[] a)
        {
            DefaultConstructor d = new DefaultConstructor();
            //  implicit constructors are parameterless public and called default and they assign default values to variable in class int(0),bool(false),string(null)
            Console.WriteLine(d.a);
            Console.WriteLine(d.s);
            Console.WriteLine(d.b);
        }
    }
}
