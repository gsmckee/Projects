using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class Savings : BankAcct
    {
        //public int Num;
        public double Bal;
        public double interest;
        static Random rand = new Random();
        private Savings() : base() { }
        public Savings (int number, double balance) : base(number, balance )
        {
            
            // Set class variables to passed in params
            this.Number = number;// Passed in param is Random.Next of 10 digits
            if (balance != 0)
            {
                this.Amount = balance - (balance * 0.1);
            }
            else
                this.Amount = balance;
            this.Bal = Amount;
            interest = Math.Round(rand.NextDouble() + 1, 2);
        }
        public override string ToString()// Override for displaying class data
        {
            string info = "Account # : " + Number.ToString() + "\n Balance : " + Amount.ToString()
                + "\n Interest Rate : " + interest.ToString();
            return info;
        }
    }
}