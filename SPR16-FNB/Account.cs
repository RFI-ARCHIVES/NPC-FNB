using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR16_FNB
{
    [Serializable]
    public abstract class Account
    {
        private int number;
        private int owner; //customer number;
        private string type; //indicates 'checking' or 'savings'
        private double balance;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    [Serializable]
    class SavingsAccount : Account
    {
        private double limit; //limit on monthly transfers
        private double rate; //interest rate
        
        /// <summary>
        /// Monthly Transfer Limit
        /// </summary>
        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        /// <summary>
        /// Rate on interest bearing accounts
        /// </summary>
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
 
     }

    [Serializable]
    /// <summary>
    /// Checking account with connected Savings Account
    /// </summary>
    class CheckingAccount : Account
    {
        private int savingsAccount; //attached savaing account for over drafts
        private double fee;  //monthly service fee

        /// <summary>
        /// Connected Savings Account Number
        /// </summary>
        public int SavingsAccount
        {
            get { return savingsAccount; }
            set { savingsAccount = value; }
        }

        /// <summary>
        /// Monthly Service Fee
        /// </summary>
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
 

    }
}
