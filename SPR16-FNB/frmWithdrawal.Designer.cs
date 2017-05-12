namespace SPR16_FNB
{
    partial class frmWithdrawal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxCustomers = new System.Windows.Forms.ComboBox();
            this.cmbxAccounts = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxCustomers
            // 
            this.cmbxCustomers.FormattingEnabled = true;
            this.cmbxCustomers.Location = new System.Drawing.Point(67, 76);
            this.cmbxCustomers.Name = "cmbxCustomers";
            this.cmbxCustomers.Size = new System.Drawing.Size(121, 28);
            this.cmbxCustomers.TabIndex = 0;
            this.cmbxCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbxCustomers_SelectedIndexChanged);
            // 
            // cmbxAccounts
            // 
            this.cmbxAccounts.FormattingEnabled = true;
            this.cmbxAccounts.Location = new System.Drawing.Point(245, 75);
            this.cmbxAccounts.Name = "cmbxAccounts";
            this.cmbxAccounts.Size = new System.Drawing.Size(121, 28);
            this.cmbxAccounts.TabIndex = 1;
            this.cmbxAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbxAccounts_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(67, 380);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 37);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(67, 303);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 26);
            this.tbxAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select an Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Withdrawal Amount";
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(67, 168);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(100, 26);
            this.tbxAccount.TabIndex = 7;
            this.tbxAccount.TextChanged += new System.EventHandler(this.tbxAccount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Account Number";
            // 
            // frmWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbxAccounts);
            this.Controls.Add(this.cmbxCustomers);
            this.Name = "frmWithdrawal";
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.frmWithdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxCustomers;
        private System.Windows.Forms.ComboBox cmbxAccounts;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.Label label4;
    }
}