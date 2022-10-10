using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
     class Stringreversal
    {
        public static void main()
        {
            string s = Console.ReadLine();

            string reverse = "";
            for (int i = (s.Length - 1); i >= 0; i--)
            {

                reverse = reverse + s[i];

            }
            Console.WriteLine(reverse);
        }
    }
}
