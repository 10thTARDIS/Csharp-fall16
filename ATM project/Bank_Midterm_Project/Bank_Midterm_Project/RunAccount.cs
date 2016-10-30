using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bank_Midterm_Project
{
    public class RunAccount
    {
        //Account[] acctArray = new Account[3];
        //RunAccount ra = new RunAccount();
        //private static int i;
        bool acctsloaded = false;
        //object acctArray = null;
        object[] acctArray = { 100, 100, 100 };
        bool acctscreated = true;

        public static void Main(String[] args)
        {
            RunAccount ra = new RunAccount();
            int input;
            do
            {
                //int[] acctArray = { 100, 100, 100 };
                //ra.acctscreated = true;

                Console.WriteLine("Please enter a choice:");
                //Console.WriteLine("1) Populate Accounts");
                Console.WriteLine("1) Load Accounts From File");
                Console.WriteLine("2) Select Account");
                Console.WriteLine("3) Exit");

                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1 && ra.acctsloaded == false) /*&& ra.acctscreated == false)*/
                {
                    //ra.populateArray();
                    ra.readArray();
                }
                else if (input == 2 && ra.acctscreated == true || ra.acctsloaded == true)  /*&& ra.acctsloaded == false && ra.acctscreated == false)*/
                {
                    ra.pickAccountMenu();
                }
                else if (input == 3) /*&& ra.acctscreated == true || ra.acctsloaded == true)*/
                {
                    ra.writeArray();
                    Console.WriteLine("\nYour changes have been saved.  Goodbye.");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                //else if (input == 4)
                //{
                //    ra.writeArray();
                //}
                else
                {
                    if (input == 1 && ra.acctsloaded == true) /*ra.acctscreated == true)*/
                    {
                        //Console.WriteLine("You have already populated the accounts.  Please try again.");
                        Console.WriteLine("You have already loaded the accounts.  Please try again.");
                    }
                    else if (input == 2 && ra.acctsloaded == true)
                    {
                        Console.WriteLine("You have already loaded the accounts.  Please try again.");
                    }
                }


            } while (input != 5);
        }

        public void writeArray()
        {
            Stream FileStream = File.Create("test.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Account[]));
            serializer.Serialize(FileStream, acctArray);
            FileStream.Close();

            //Console.WriteLine("\nYour changes have been saved.  Goodbye.");
        }

        public void readArray()
        {
            Stream FileStream = File.OpenRead("test.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Account[]));
            acctArray = (Account[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            acctsloaded = true;
        }


        //public void populateArray()
        //{
        //    //prompt for username
        //    //Console.WriteLine("Please enter three account numbers, separated by spaces:");
        //    //string[] tokens = Console.ReadLine().Split();
        //    //for (int i = 0; i < acctArray.Length; i++)
        //    //{
        //    //    acctArray[i] = new Account(tokens[i]);
        //    //}
        //    int[] acctArray = { 100, 100, 100 };
        //    acctscreated = true;
        //}

        public void pickAccountMenu()
        {
            string sinput = null;
            int input = -1;
            while (input != -99)
            {
                Console.WriteLine("Please enter the account number (0, 1, or 2).  -99 to exit.");
                sinput = Console.ReadLine();
                input = Convert.ToInt32(sinput);
                if (input != -99)
                {
                    acctArray[Account.ID].menu();
                    Account acc = new Account();  //this is a stopgap to let us test other stuff MUST BE REMOVED
                    acc.menu();
                }
                else Console.WriteLine("Goodbye.");
            }
        }
    }
}