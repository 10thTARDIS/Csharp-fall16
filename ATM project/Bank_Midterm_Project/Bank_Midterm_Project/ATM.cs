using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Midterm_Project
{
    public class ATM
    {
        bool acctsPopulated;
        //Account[] acctArray = new Account[3];
        public void mainATM()
        {
            ATM atm = new ATM();
            atm.topMenu();
        }
        public void topMenu()
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
                    Account acc = new Account();
                    acc.deposit();
                }

                else if (input == 2)
                {
                    Account acc = new Account();
                    acc.withdraw();
                }

                else if (input == 3)
                {
                    Account acc = new Account();
                    acc.calcInt();
                }

                else if (input == 4)
                {

                }


                else if (input != 1 || input != 2 || input != 3 || input != 4) //not finished.  || = or, && = and
                {
                    Console.WriteLine("Invalid input, please try again.");

                }
            }
        }

            public void PopulateAccounts()
        {
            //for(int i = 0; i < acctArray.Length; i++)
            {
                //acctArray[i] = new Account(100.00);
            }
            acctsPopulated = true;
        }


        public void SelectAccount()
        {
            Console.WriteLine("Which account?");
            int input = Convert.ToInt32(Console.ReadLine());
            //acctArray[input - 1].menu();
        }
        // squigly line in picture
        public void newAccount()
        {
            
        {
            Console.WriteLine("1) Deposit");
        }
    }
    //black marker line

    //double dollar.Amount = 0.91;
    //interface quarters = dollarAmount / 0.25;
    //double tempDollars = dollarAmmount % 0.25;
    //int quarters = (int)dollarAmount / 0.25;
    //black marker line

    //int myInt = ReturnValue();
    //int ReturnValue()
    //{
    //    return 5;
    //}
    //public static void Main(String[] args)
    //    {
    //        Account myAcct = new Account(); // Outside the main method it is a field/attribute, and calling it in static will cause issues.
    //        myAcct.menu();


    //    }


    }
}
