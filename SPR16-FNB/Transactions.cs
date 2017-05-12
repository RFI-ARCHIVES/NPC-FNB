using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR16_FNB
{
    public class Transactions
    {
        private int number;
        private int fromAccount;
        private int toAccount;
        private double amount;
        private DateTime date;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public int ToAccount
        {
            get { return toAccount; }
            set { toAccount = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}
