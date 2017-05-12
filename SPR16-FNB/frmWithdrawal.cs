using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPR16_FNB
{
    public partial class frmWithdrawal : Form
    {
        int ownerNumber;
        int accountNumber = 0;

    
        public frmWithdrawal()
        {
            InitializeComponent();
        }

        private void frmWithdrawal_Load(object sender, EventArgs e)
        {
            foreach (Customer cust in frmMain.custList)
            {
                cmbxCustomers.Items.Add(cust.LastName + ", " + cust.FirstName);
            }
        }

        private void cmbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerNumber = frmMain.custList[cmbxCustomers.SelectedIndex].Number;
            foreach (Account acct in frmMain.acctList)
            {
                if (acct.Owner == ownerNumber)
                    cmbxAccounts.Items.Add(acct.Number);
            }
            tbxAccount.Enabled = false;

        }

        private void cmbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountNumber = Convert.ToInt16(cmbxAccounts.SelectedItem);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool accountFound = false;

            if (accountNumber == 0)
                accountNumber = Convert.ToInt16(tbxAccount.Text);

            foreach (Account acct in frmMain.acctList)
            {
                if (acct.Number == accountNumber)
                {
                    acct.Balance -= Convert.ToInt16(tbxAmount.Text);
                    MessageBox.Show("Withdrawal Completed");
                    accountFound = true;
                    this.Close();
                }
            }

            if (accountFound == false)
            {
                MessageBox.Show("account not Found");
                
            }
        }

        private void tbxAccount_TextChanged(object sender, EventArgs e)
        {
            cmbxCustomers.Enabled = false;
            cmbxAccounts.Enabled = false;
        }

 




    }
}
