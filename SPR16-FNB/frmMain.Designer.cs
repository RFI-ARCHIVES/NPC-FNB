namespace SPR16_FNB
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnBuildCustomers = new System.Windows.Forms.Button();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnBuildAccounts = new System.Windows.Forms.Button();
            this.btnShowAccounts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckingDeposits = new System.Windows.Forms.Label();
            this.lblSavingsDeposits = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(43, 137);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(87, 19);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(43, 161);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(87, 19);
            this.btnNewAccount.TabIndex = 1;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(43, 184);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(87, 19);
            this.btnWithdrawal.TabIndex = 2;
            this.btnWithdrawal.Text = "WIthdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(43, 231);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(87, 19);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 367);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 19);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(43, 343);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(87, 19);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save All Data";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnBuildCustomers
            // 
            this.btnBuildCustomers.ForeColor = System.Drawing.Color.Maroon;
            this.btnBuildCustomers.Location = new System.Drawing.Point(516, 8);
            this.btnBuildCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuildCustomers.Name = "btnBuildCustomers";
            this.btnBuildCustomers.Size = new System.Drawing.Size(63, 51);
            this.btnBuildCustomers.TabIndex = 8;
            this.btnBuildCustomers.Text = "Build Sample Customers";
            this.btnBuildCustomers.UseVisualStyleBackColor = true;
            this.btnBuildCustomers.Click += new System.EventHandler(this.btnBuildCustomers_Click);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(280, 137);
            this.lblCustomerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerCount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customers:";
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowCustomers.Location = new System.Drawing.Point(515, 63);
            this.btnShowCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(64, 53);
            this.btnShowCustomers.TabIndex = 9;
            this.btnShowCustomers.Text = "Show Customer List";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnBuildAccounts
            // 
            this.btnBuildAccounts.ForeColor = System.Drawing.Color.Maroon;
            this.btnBuildAccounts.Location = new System.Drawing.Point(583, 8);
            this.btnBuildAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuildAccounts.Name = "btnBuildAccounts";
            this.btnBuildAccounts.Size = new System.Drawing.Size(63, 51);
            this.btnBuildAccounts.TabIndex = 13;
            this.btnBuildAccounts.Text = "Build Sample Accounts";
            this.btnBuildAccounts.UseVisualStyleBackColor = true;
            this.btnBuildAccounts.Click += new System.EventHandler(this.btnBuildAccounts_Click);
            // 
            // btnShowAccounts
            // 
            this.btnShowAccounts.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowAccounts.Location = new System.Drawing.Point(583, 63);
            this.btnShowAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAccounts.Name = "btnShowAccounts";
            this.btnShowAccounts.Size = new System.Drawing.Size(63, 51);
            this.btnShowAccounts.TabIndex = 14;
            this.btnShowAccounts.Text = "Show Accounts List";
            this.btnShowAccounts.UseVisualStyleBackColor = true;
            this.btnShowAccounts.Click += new System.EventHandler(this.btnShowAccounts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Accounts:";
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(280, 150);
            this.lblAccounts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(0, 13);
            this.lblAccounts.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Checking:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Savings:";
            // 
            // lblCheckingDeposits
            // 
            this.lblCheckingDeposits.AutoSize = true;
            this.lblCheckingDeposits.Location = new System.Drawing.Point(371, 150);
            this.lblCheckingDeposits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckingDeposits.Name = "lblCheckingDeposits";
            this.lblCheckingDeposits.Size = new System.Drawing.Size(13, 13);
            this.lblCheckingDeposits.TabIndex = 19;
            this.lblCheckingDeposits.Text = "0";
            // 
            // lblSavingsDeposits
            // 
            this.lblSavingsDeposits.AutoSize = true;
            this.lblSavingsDeposits.Location = new System.Drawing.Point(522, 150);
            this.lblSavingsDeposits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSavingsDeposits.Name = "lblSavingsDeposits";
            this.lblSavingsDeposits.Size = new System.Drawing.Size(13, 13);
            this.lblSavingsDeposits.TabIndex = 20;
            this.lblSavingsDeposits.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(512, 211);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(43, 207);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(87, 20);
            this.btnDeposit.TabIndex = 23;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(468, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 51);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(679, 399);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSavingsDeposits);
            this.Controls.Add(this.lblCheckingDeposits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAccounts);
            this.Controls.Add(this.btnBuildAccounts);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btnBuildCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.btnNewCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "First National Bank of NPC";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnBuildCustomers;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnBuildAccounts;
        private System.Windows.Forms.Button btnShowAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckingDeposits;
        private System.Windows.Forms.Label lblSavingsDeposits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDelete;
    }
}

