using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Midterm_Project
{
    public class Account
    {
                public double balance = 100;
        double depositAmount = 0;
        double withdrawalAmount = 0;
        //double total = 100;
        double intRate = 0.05;
        DateTime d1 = new DateTime(2016, 1, 1);
        DateTime d2 = DateTime.Now;
        String ID;
        double totalDays;
        double interest;

        public Account(String arg_ID)
        {
            ID = arg_ID;
        }
        public Account()
        {

        }
        public void datePrompt()
        {
            //Console.WriteLine("Please enter date in [mm / dd / yyyy]");
            //string mydate = Console.ReadLine();
            //DateTime d2 = DateTime.Now;
            //string format = "d/M/yyyy";
            //Console.WriteLine(DateTime.Now.ToString(format));
        }

        public void menu()
        {
            RunAccount ra = new RunAccount();
            object an;
            an = (object)ra.accountNumber;
            balance = (double)ra.acctArray[Array.IndexOf(ra.acctArray, ra.accountNumber)];
            int input = 0;
            while (input != 4)
            {
                //We call Calculate Interest at the start of the program, to prevent later changes from affecting interest.
                calcInt();

                Console.WriteLine("\nWelcome to the Bank of UMSL.\n\nPlease enter a choice:\n");
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
                    checkBalance();
                }

                else if (input == 4)
                {
                    Console.WriteLine("Thank you for banking with the Bank of UMSL.");
                    //RunAccount ra = new RunAccount();
                    ra.writeArray();
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }


                else if (input != 1 || input != 2 || input != 3 || input != 4)
                {
                    Console.WriteLine("Invalid input, please try again.");

                }
            }
        }

        public void deposit()
        {
            //Console.WriteLine("Please enter the current date:\n");
            Console.WriteLine("\nEnter amount of deposit");
            depositAmount = Convert.ToInt32(Console.ReadLine());
            balance = balance + depositAmount;
            Console.WriteLine("\n\nCongratulations, you have successfully deposited $" + depositAmount + " into your account.\nYour total balance is currently $" + balance + "\n\n");
        }
        public void withdraw()
        {
            //Console.WriteLine("Please enter the current date:\n");
            Console.WriteLine("\nEnter amount of withdrawal:\t");
            withdrawalAmount = Convert.ToInt32(Console.ReadLine());
            balance = balance - withdrawalAmount;
            Console.WriteLine("\n\nCongratulations, you have successfully withdrawn $" + withdrawalAmount + " from your account.\nYour total balance is currently $" + balance + "\n\n");
        }

        public void calcInt()
        {
            //Console.WriteLine("Please enter the current date:");

            totalDays = (d2 - d1).TotalDays;
            interest = (totalDays / 365) * intRate;
            balance += interest;
            balance = Math.Round(balance, 2);
            interest = Math.Round(interest, 2);

        }

        public void checkBalance()
        {
            //calcInt();
            Console.WriteLine("\n\nYour current balance as of " + d2 + " is $" + balance + "\nYou have earned $" + interest + " in interest to date.\n\n");
        }
    }
}
