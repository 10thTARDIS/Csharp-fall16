using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Account
    {
        double balance;
        double depositAmount = 0;
        double total = 0;

        public void deposit()
        {
            Console.WriteLine("Enter amount of deposit");
            depositAmount = Convert.ToInt32(Console.ReadLine());
            total = total + depositAmount;
            Console.WriteLine("Congratulations, you have successfully deposited $" + depositAmount + " into your account.\nYour total balance is currently $" + total);

        }
        public void withdraw()
        {
            Console.WriteLine("I'm in withdraw");

        }

        public void calcInt()
        {
            Console.WriteLine("I'm in Check Balance");
        }
        public void menu()
        {
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("Please enter a choice:");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Check Balance");
                Console.WriteLine("4) Exit");

                input = Convert.ToInt32(Console.ReadLine());


                if (input == 1)
                {
                    deposit();

                }

                else if (input == 2)
                {
                    withdraw();

                }

                else if (input == 3)
                {
                    calcInt();

                }

                else if (input == 4)
                {

                }


                else if (input != 1 || input != 2 || input != 3 || input != 4) //not finished.  || = or, && = and
                {
                    Console.WriteLine("Invalid input");

                }
            }


        }


    }
}
