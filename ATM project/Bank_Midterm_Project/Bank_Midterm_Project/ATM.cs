using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ATM
    {
        public static void Main(String[] args)
        {
            Account myAcct = new Account(); // Outside the main method it is a field/attribute, and calling it in static will cause issues.
            myAcct.menu();


        }


    }
}
