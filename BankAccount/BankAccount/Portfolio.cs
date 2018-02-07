using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    
    public class Portfolio
    {
        public double realEst;
        public double stock;
        public Checking checking;
        public Savings savings;
        public int ID;
        public string clientName;
        Random rand;

        // Default constructor for Portfolio class requires user entry from Main.
        public Portfolio(int user, double balance)
        {
            rand = new Random();
            this.checking = new Checking(rand.Next(100000000, 200000000), balance);
            this.savings = new Savings(rand.Next(100000000, 200000000), balance);
            realEst = rand.NextDouble()* 10000;
            stock = rand.NextDouble() * 10000;
            ID = user;                        
        }
        public Portfolio(string cName, double balance)
        {
            rand = new Random();
            this.clientName = cName;
            this.checking = new Checking(rand.Next(100000000, 200000000), balance);
            this.savings = new Savings(rand.Next(100000000, 200000000), balance);
            realEst = rand.NextDouble() * 10000;
            stock = rand.NextDouble() * 10000;
            ID = rand.Next();
        }
        public override string ToString()// Override for displaying class data
        {
            realEst = Round(realEst);
            stock = Round(stock);
            string info ="User ID: " + Convert.ToString(ID) + "\n Savings Account: " + savings.ToString() + "\n Checking Account: " 
                + checking.ToString() + "\n Real Estate Investment: " + Convert.ToString(realEst) + 
                "\n Stock Investment: " + Convert.ToString(stock);
            return info;
        }
        public double Round(double investment)// Return doubles with limited fractional numbers
        {
            investment = Math.Round(investment, 2);
            return investment;
        }
    }
}
