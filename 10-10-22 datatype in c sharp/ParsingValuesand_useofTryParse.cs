using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public  class ParsingValuesand_useofTryParse
    {
        static void Main()
        {
            //string s = Console.ReadLine(); //if entered charactes other than numbers give an exception Input string was not in a correct format.'
            //double d=double.Parse(s);
            //Console.WriteLine(d);


            //using tryparse to handle exception

            string wage = Console.ReadLine();
            int wageValue;
            //int wageValue
            if (int.TryParse(wage, out wageValue))
            {

                Console.WriteLine("Parsing success: " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }
    }
}
