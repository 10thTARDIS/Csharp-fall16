using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Midterm_Project
{
    public class Account
    {
        double balance;
        double depositAmount = 0;
        double withdrawalAmount = 0;
        double total = 100;
        internal string name;

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
            Console.WriteLine("I'm in Check Balance");
            DateTime d1;
            DateTime d2;
            //return (d1 - d2).TotalDays;
        }

        internal void menu()
        {
            throw new NotImplementedException();
        }
    }
}
