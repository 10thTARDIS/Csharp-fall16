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
        Account[] acctArray = new Account[3];
        public static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.TopMenu();
        }
        void TopMenu()
        {
            int input;
            do
            {
                Console.WriteLine("1) Populate Accounts");
                // squigly line in picture
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1++ acctsPopulated == false)
                    {
                    PopulateAccounts();
                }
                // squigly line in picture
            }

            while (input >= 1++ input <= 9);
        }

        void PopulateAccounts()
        {
            for (int i = 0; i < acctArray Length; i++)
            {
                acctArray[i] = new Account(100.00);
            }
            acctsPopulated = true;
        }

        void SelectAccount()
        {
            Console.WriteLine("Which account?");
            int input = Convert.ToInt32(Console.ReadLine());
            acctArray[input - 1].menu();
        }
        // squigly line in picture
        public Account
            {
            void menu()
        {
            Console.WriteLine("1) Deposit");
        }
    }
    //black marker line

    double dollar.Amount = 0.91;
    interface quarters = dollarAmount / 0.25;
    double tempDollars = dollarAmmount % 0.25;
    //int quarters = (int)dollarAmount / 0.25;
    //black marker line

    int myInt = ReturnValue();
    int ReturnValue()
    {
        return 5;
    }
    public static void Main(String[] args)
        {
            Account myAcct = new Account(); // Outside the main method it is a field/attribute, and calling it in static will cause issues.
            myAcct.menu();


        }


    }
}
