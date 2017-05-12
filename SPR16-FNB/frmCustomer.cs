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
    
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            tbxAccountNumber.Text = getNextCustomerNumber().ToString();
        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Number = getNextCustomerNumber();
            cust.FirstName = tbxFirstName.Text;
            cust.LastName = tbxLastName.Text;
            cust.Address1 = tbxAddress1.Text;
            cust.Address2 = tbxAddress2.Text;
            cust.City = tbxCity.Text;
            cust.State = tbxState.Text;
            cust.Zip = tbxZip.Text;
            cust.Email = tbxEmail.Text;
            cust.Phone = tbxPhone.Text;

            frmMain.custList.Add(cust);
            this.Close();
        }


       private int getNextCustomerNumber()
        {
            //int numCustomers = frmMain.custList.Count;
            //Customer cust = frmMain.custList[numCustomers - 1];
            //int nextCustomer = cust.Number + 1;
            //return nextCustomer;

            if (frmMain.custList.Count == 0)
               return 1000;
            else
               return frmMain.custList[frmMain.custList.Count - 1].Number + 1;
        }
 

 
    }
}
