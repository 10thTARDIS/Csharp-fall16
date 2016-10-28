using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Midterm_Project
{
    public class Account
    {
        double balance = 100;
        double depositAmount = 0;
        double withdrawalAmount = 0;
        double total = 100;
        DateTime d1;
        DateTime d2;
        String ID;

        public Account(String arg_ID)
        {
            ID = arg_ID;
        }

        public void menu()
        {
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("Welcome to the Bank of UMSL.\n Please enter a choice:");
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
                    Console.WriteLine("Thank you for banking with the Bank of UMSL.");
                    RunAccount ra = new RunAccount();
                    ra.writeArray();
                }


                else if (input != 1 || input != 2 || input != 3 || input != 4) //not finished.  || = or, && = and
                {
                    Console.WriteLine("Invalid input, please try again.");

                }
            }
        }

        public void deposit()
        {
            Console.WriteLine("Enter amount of deposit");
            depositAmount = Convert.ToInt32(Console.ReadLine());
            total = total + depositAmount;
            Console.WriteLine("Congratulations, you have successfully deposited $" + depositAmount + " into your account.\nYour total balance is currently $" + total);
        }
        public void withdraw()
        {
            Console.WriteLine("Enter amount of withdrawal:\t");
            withdrawalAmount = Convert.ToInt32(Console.ReadLine());
            total = total - withdrawalAmount;
            Console.WriteLine("Congratulations, you have successfully withdrawn $" + withdrawalAmount + " from your account.\nYour total balance is currently $" + total);
        }

        public void calcInt()
        {
            Console.WriteLine("Please enter the current date:");
            
            //return (d1 - d2).TotalDays;
            Console.WriteLine("Your current balance as of " + d1 + " is $" + balance);
        }

        
    }
}
