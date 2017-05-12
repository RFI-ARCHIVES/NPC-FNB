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
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int FromAccountIndex = 0;
            int ToAccountIndex = 0;
            bool FromAccountFound = false;
            bool ToAccountFound = false;

            Transactions trans = new Transactions();
            trans.ToAccount = Convert.ToInt16(tbxTo.Text);
            trans.FromAccount = Convert.ToInt16(tbxFrom.Text);
            trans.Amount = Convert.ToDouble(tbxAmount.Text);
            trans.Date = System.DateTime.Now;
            trans.Number = 1000;

            for (int i = 0; i < frmMain.acctList.Count; i++)
			{
			  if (trans.FromAccount == frmMain.acctList[i].Number)
              {
                  FromAccountIndex = i;
                  FromAccountFound = true;
                  break;
              }

			}

            for (int i = 0; i < frmMain.acctList.Count; i++)
            {
                if (trans.ToAccount == frmMain.acctList[i].Number)
                {
                    ToAccountIndex = i;
                    ToAccountFound = true;
                    break;
                }
            }

            if ((frmMain.acctList[FromAccountIndex].Balance >= trans.Amount) && FromAccountFound && ToAccountFound)
            {
                frmMain.acctList[FromAccountIndex].Balance -= trans.Amount;
                frmMain.acctList[ToAccountIndex].Balance += trans.Amount;
                frmMain.transList.Add(trans);
                this.Close();
            }
            else
            {
                MessageBox.Show("Transaction Failed");
            }

        }
    }
}
