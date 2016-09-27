using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Midterm_Project  // This is the example from class, as an intro to arrays.
{
    class InitArray
    {
        public static void Main(string[] args)
        {
            int[] array;
            array = new int[5];
            Console.WriteLine("{1}{1,8}", "Index", "Value");
            for (int counter = 0; counter < array.Length; ++counter)
               {
                Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
                }
            Console.ReadLine();
        }
    }
}