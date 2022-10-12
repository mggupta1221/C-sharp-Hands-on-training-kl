using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handeling
{
    public class DeveloperDefinedExceptionDevidedByOddNumber:ApplicationException
    {
        public override string Message  //its an virtual readonly property in Exception class so we can override that property 
        {
            get
            {
                return "Attempted to divide  by odd number";
            }
        }
    }
}
