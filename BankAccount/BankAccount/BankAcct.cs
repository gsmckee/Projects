using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAcct
    {
        protected int Number;
        protected double Amount;

        protected BankAcct()// Default Constructor
        {
            this.Number = 0;
            this.Amount = 0;
        }
        public BankAcct(int number, double amount)// Overloaded Constructor
        {
            this.Number = number;
            this.Amount = amount;
        }
    }
}
