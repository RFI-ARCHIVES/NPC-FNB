using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SPR16_FNB
{

    public partial class frmMain : Form
    {

        //Create Customer and Account Lists
        public static List<Customer> custList;
        public static List<Account> acctList;
        public static List<Transactions> transList;
        public static string childForm;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            custList = new List<Customer>();
            acctList = new List<Account>();
            transList = new List<Transactions>();
            loadAll();

            lblCustomerCount.Text = custList.Count.ToString();
            lblAccounts.Text = acctList.Count.ToString();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (childForm == "NewAccount")
            {
                dataGridView1.DataSource = acctList;
                calculateDepositTotals();
                lblAccounts.Text = acctList.Count.ToString();
            }
            if (childForm == "NewCustomer")
            {
                dataGridView1.DataSource = custList;
                lblCustomerCount.Text = custList.Count.ToString();
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            childForm = "NewCustomer";
            frmCustomer frmCust = new frmCustomer();
            frmCust.ShowDialog();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            childForm = "NewAccount";
            frmAccount frmAcct = new frmAccount();
            frmAcct.ShowDialog();

        }       
        
        private void btnBuildCustomers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                Customer cust = new Customer();
                cust.Number = i + 9000;
                cust.FirstName = "John" + i.ToString();
                cust.LastName = "Smith" + i.ToString();
                custList.Add(cust);
                lblCustomerCount.Text = custList.Count.ToString();
            }
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = custList;
        }

        private void btnBuildAccounts_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int accountNumber = 1000;

            for (int i = 1; i <= 50; i++)
            {
                SavingsAccount savAcct = new SavingsAccount();
                CheckingAccount chkAcct = new CheckingAccount();

                savAcct.Balance = rnd.Next(10000, 20000);
                savAcct.Limit = 1000;
                savAcct.Number = accountNumber++;
                savAcct.Owner = i + 9000;
                savAcct.Type = "Saving";

                chkAcct.Balance = rnd.Next(100, 1000);//i + 100;
                chkAcct.Number = accountNumber++;
                chkAcct.Owner = i + 4000;
                chkAcct.SavingsAccount = 1001;
                chkAcct.Type = "Checking";

                acctList.Add(savAcct);
                acctList.Add(chkAcct);

                savAcct = null;
                chkAcct = null;
            }
            acctList[2].Owner = 9004;
            acctList[10].Owner = 9004;
            lblAccounts.Text = acctList.Count.ToString();
        }

        private void btnShowAccounts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = acctList;
            dataGridView1.Refresh();
            calculateDepositTotals();
        }

        private void calculateDepositTotals()
        {
            double chkDeposits = 0;
            int chkAccounts = 0;
            double savDeposits = 0;
            int savAccounts = 0;

            foreach (Account acct in acctList)
            {
                if (acct is CheckingAccount)
                {
                    chkDeposits += acct.Balance;
                    chkAccounts++;
                }
                else if (acct is SavingsAccount)
                {
                    savDeposits += acct.Balance;
                    savAccounts++;
                }
            }
            lblCheckingDeposits.Text = chkAccounts + "::" + chkDeposits.ToString("C");
            lblSavingsDeposits.Text = savAccounts + "::" + savDeposits.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsCust = new FileStream("c:\\myfiles\\customers.bin", FileMode.Create);

            FileStream fsAcct = new FileStream("c:\\myfiles\\accounts.bin", FileMode.Create);
            foreach (Customer cust in custList)
            {
                formatter.Serialize(fsCust, cust);
            }
            foreach (Account acct in acctList)
            {
                formatter.Serialize(fsAcct, acct);
            }
        }

        private void loadAll()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsCust = new FileStream("c:\\myfiles\\customers.bin", FileMode.Open);
            FileStream fsAcct = new FileStream("c:\\myfiles\\accounts.bin", FileMode.Open);

            while (fsAcct.Position != fsAcct.Length)
            {
                Account acct = (Account)formatter.Deserialize(fsAcct);
                acctList.Add(acct);
            }


            while (fsCust.Position != fsCust.Length)
            {
                Customer cust = (Customer)formatter.Deserialize(fsCust);
                custList.Add(cust);
            }

            lblAccounts.Text = acctList.Count.ToString();
            lblCustomerCount.Text = custList.Count.ToString();

            fsAcct.Close();
            fsCust.Close();

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            Form frmWithdraw = new frmWithdrawal();
            frmWithdraw.ShowDialog();
        }

 
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Form frmTransfer = new frmTransaction();
            frmTransfer.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form frmDeposit = new frmDeposit();
            frmDeposit.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            custList.Clear();
            acctList.Clear();

        }

        private void frmMain_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {

        }




    }

}
