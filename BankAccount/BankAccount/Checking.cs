using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class Checking : BankAcct
    {
        //public int Num;
        public double Bal;
        private Checking() : base() { }// Call base default construstor
        public Checking(int user, double balance): base( user, balance )// Call base overloaded constructor
        {
            // Set class variables to passed in params
            this.Number = user;// Passed in param is Random.Next of 10 digits
            if (balance != 0)
            {
                this.Amount = balance * 0.1;// Initial checking balance set to a default of 0
            }
            else
                this.Amount = balance;
            this.Bal = Amount;
        }
        public override string ToString()// Override for displaying class data
        {
            string info = "Account # : " + Number + "\n Balance : " + Amount.ToString();
            return info;
        }
    }
}