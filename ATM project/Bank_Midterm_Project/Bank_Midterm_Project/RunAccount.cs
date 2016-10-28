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
        Account[] acctArray = new Account[3];
        RunAccount ra = new RunAccount();
        //private static int i;
        bool acctscreated = false;
        bool acctsloaded = false;
        public static void Main(String[] args)
        {
            RunAccount ra = new RunAccount();
            int input;
            do
            {
                Console.WriteLine("Please enter a choice:");
                Console.WriteLine("1) Populate Accounts");
                Console.WriteLine("2) Load Accounts From File");
                Console.WriteLine("3) Select Account");
                Console.WriteLine("4) Exit");

                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1 && ra.acctscreated == false)
                {
                    ra.populateArray();
                }
                else if (input == 2 && ra.acctsloaded == false)
                {
                    ra.readArray();
                }
                else if (input == 3 && ra.acctscreated == true)
                {
                    ra.pickAccountMenu();
                }
                else if (input == 4)
                {
                    ra.writeArray();
                }
                else
                {
                    if (input == 1 && ra.acctscreated == true)
                    {
                        Console.WriteLine("You have already populated the accounts.  Please try again.");
                    }
                    else if (input == 2 && ra.acctscreated == true)
                    {
                        Console.WriteLine("You have already loaded the accounts.  Please try again.");
                    }
                    else if (input == 3 && ra.acctscreated == false)
                    {
                        Console.WriteLine("You must create the accounts first.  Please try again.");
                    }
                }


            } while (input != 5);
        }
                //ATM atm = new ATM();
                //atm.topMenu();



        public void writeArray()
        {
            Console.WriteLine("\nYour changes have been saved.  Goodbye.");

            Stream FileStream = File.Create("test.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Account[]));
            serializer.Serialize(FileStream, ra.acctArray);
            FileStream.Close();
        }

        public void readArray()
        {
            Stream FileStream = File.OpenRead("test.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Account[]));
            acctArray = (Account[])deserializer.Deserialize(FileStream);
            FileStream.Close();
        }


        public void populateArray()
        {
            //int[] acctArray = new int[3];
            //prompt for username
            Console.WriteLine("Please enter three account numbers, separated by spaces:");
            string[] tokens = Console.ReadLine().Split();
            for (int i = 0; i < acctArray.Length; i++)
            {
                acctArray[i] = new Account(tokens[i]);
            }
            acctscreated = true;
        }

        public void pickAccountMenu()
        {
            string sinput = null;
            int input = -1;
            while (input != 4)
            {
                Console.WriteLine("Please enter 0, 1, or 2 for your account.  4 to quit.");
                sinput = Console.ReadLine();
                input = Convert.ToInt32(sinput);
                if (input != -99)
                {
                    ra.acctArray[input].menu();
                }
            }
        }
    }

}
