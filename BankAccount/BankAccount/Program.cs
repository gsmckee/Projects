using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            string client;
            string amountToConvert;
            double deposit;
            Random user = new Random();
            Random amount = new Random();
            Dictionary<int, int> accounts = new Dictionary<int, int>();
            List<Portfolio> clients = new List<Portfolio>();
            Portfolio p;
            Portfolio p2;
            Portfolio p3;
            Portfolio p4;
            Console.WriteLine("Enter your Name: ");
            client = Convert.ToString(Console.ReadLine());
            while (client != null)
            {
                Console.WriteLine("Enter the amount you would like to start with in your savings");
                amountToConvert = Convert.ToString(Console.ReadLine());
                if (double.TryParse(amountToConvert, out deposit))
                {
                    p4 = new Portfolio(client, deposit);
                    clients.Add(p4);
                    client = null;
                }
                else
                {
                    Console.WriteLine("This is not a valid amount.");
                }
            }
            p = new Portfolio(user.Next(), 2048657);
            p2 = new Portfolio(user.Next(), 244532);
            p3 = new Portfolio(user.Next(), 30);
            clients.Add(p);
            clients.Add(p2);
            clients.Add(p3);
            Console.WriteLine(p.ToString());
            clients.ForEach(Console.WriteLine);
            Console.WriteLine(fortyPerOfTotal(p));
            Console.WriteLine(fortyPerOfTotal(p2));
            Console.WriteLine(fortyPerOfTotal(p3));
            Console.Read();
        }
        static public string fortyPerOfTotal(Portfolio p)// Perform check on balances to identify one that is more than 40% of the total
        {
            string response = "";
            double total = p.checking.Bal + p.savings.Bal + p.realEst + p.stock;
            double cPerOfTotal = (p.checking.Bal / total) * 100;
            double sPerOfTotal = (p.savings.Bal / total) * 100;
            double rePerOfTotal = (p.realEst / total) * 100;
            double stockPerOfTotal = (p.stock / total) * 100;
            int percent = 40;
            if (cPerOfTotal >= percent)
            {
                response = "Your Checking account is 40% of your total portfolio balance.";
            }
            else if (sPerOfTotal >= percent)
            {
                response = "Your Savings account is 40% of your total portfolio balance.";
            }
            else if (rePerOfTotal >= percent)
            {
                response = "Your Real Estate investments account is 40% of your total portfolio balance.";
            }
            else if (stockPerOfTotal >= percent)
            {
                response = "Your Stock investments account is 40% of your total portfolio balance.";
            }
            return response;
        }
        //public bool userExists(int user)
        //{
        //    if (!accounts)
        //    {
        //        Random id = new Random();
        //        int ID = id.Next();
        //        accounts.Add(user, ID);
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public void detriment(Portfolio p)
        //{

        //}
    }
}

//    }
//    else
//        Console.Write("You need to open your account with a positive balance.");
//}
//else
//    Console.Write("User already exists!");      
