using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SPR16_FNB
{
   
    public partial class frmAccount : Form
    {
        int ownerNumber;
        int nextAccount;

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            //populate customer combobox
            foreach (Customer cust in frmMain.custList)
            {
                cmbxOwner.Items.Add(cust.LastName + ", " + cust.FirstName);
            }

            //get and display next available account number
            //nextAccount = getNextAccountNumber();
            //tbxAccountNumber.Text = nextAccount.ToString();

            nextAccount = getNextAccountNumber();
            tbxAccountNumber.Text = nextAccount.ToString();


            //populate account combobox
            foreach (Account acct in frmMain.acctList)
            {
                if (acct.Number == ownerNumber)
                {
                    cmbxAttachedAccount.Items.Add(acct.Number);
                }
            }
        }

        private int getNextAccountNumber()
        {
            if (frmMain.acctList.Count == 0)
                return 10000;
            else
              return frmMain.acctList[frmMain.acctList.Count - 1].Number + 1;
        }

        private void cmbxOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerNumber = frmMain.custList[cmbxOwner.SelectedIndex].Number;
            tbxOwnerNumber.Text = ownerNumber.ToString();
            //populate account combobox with savings accounts owned by customer
            foreach (Account acct in frmMain.acctList)
            {
                if (acct is SavingsAccount && acct.Owner == ownerNumber)
                    cmbxAttachedAccount.Items.Add(acct.Number);
            }
        }

        private void cmbxAttachedAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //record the attached savings account number
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            //add the new account to the list and return
            if (rbChecking.Checked)
            {
                CheckingAccount chkAcct = new CheckingAccount();
                chkAcct.Number = nextAccount;
                chkAcct.Owner = ownerNumber;
                chkAcct.SavingsAccount = Convert.ToInt16(cmbxAttachedAccount.SelectedValue);
                chkAcct.Type = "Checking";
                frmMain.acctList.Add(chkAcct);
                this.Close();
            }
            else if (rbSavings.Checked)
            {
                SavingsAccount savAcct = new SavingsAccount();
                savAcct.Number = nextAccount;
                savAcct.Owner = ownerNumber;
                savAcct.Type = "Savings";
                frmMain.acctList.Add(savAcct);
                this.Close();
            }
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
            cmbxAttachedAccount.Enabled = true;
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
            cmbxAttachedAccount.Enabled = false;

        }
    }
}
