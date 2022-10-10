using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public class Typechanging
    {
        public static void Main(String[] args)
        {
            //implicit by compiler (smaller to bigger)
            int a = 1234567;
            long l = a;

            //Explicit Casting (bigger to smaller)
            long l1 = 12345;
            int a1 = (int)l1;

            //Using Convert.Changetype helper bigger to smaller

            double d = 1267.77;
            int a2= (int) Convert.ChangeType(d, typeof(int));

        }
    }
}
