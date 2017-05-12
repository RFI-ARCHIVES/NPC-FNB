namespace SPR16_FNB
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.cmbxOwner = new System.Windows.Forms.ComboBox();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.rbChecking = new System.Windows.Forms.RadioButton();
            this.cmbxAttachedAccount = new System.Windows.Forms.ComboBox();
            this.btnSaveAndReturn = new System.Windows.Forms.Button();
            this.tbxOwnerNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.Enabled = false;
            this.tbxAccountNumber.Location = new System.Drawing.Point(231, 343);
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.Size = new System.Drawing.Size(100, 26);
            this.tbxAccountNumber.TabIndex = 0;
            // 
            // cmbxOwner
            // 
            this.cmbxOwner.FormattingEnabled = true;
            this.cmbxOwner.Location = new System.Drawing.Point(231, 374);
            this.cmbxOwner.Name = "cmbxOwner";
            this.cmbxOwner.Size = new System.Drawing.Size(206, 28);
            this.cmbxOwner.TabIndex = 1;
            this.cmbxOwner.SelectedIndexChanged += new System.EventHandler(this.cmbxOwner_SelectedIndexChanged);
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Location = new System.Drawing.Point(465, 442);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(90, 24);
            this.rbSavings.TabIndex = 2;
            this.rbSavings.TabStop = true;
            this.rbSavings.Text = "Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            this.rbSavings.CheckedChanged += new System.EventHandler(this.rbSavings_CheckedChanged);
            // 
            // rbChecking
            // 
            this.rbChecking.AutoSize = true;
            this.rbChecking.Location = new System.Drawing.Point(465, 474);
            this.rbChecking.Name = "rbChecking";
            this.rbChecking.Size = new System.Drawing.Size(100, 24);
            this.rbChecking.TabIndex = 3;
            this.rbChecking.TabStop = true;
            this.rbChecking.Text = "Checking";
            this.rbChecking.UseVisualStyleBackColor = true;
            this.rbChecking.CheckedChanged += new System.EventHandler(this.rbChecking_CheckedChanged);
            // 
            // cmbxAttachedAccount
            // 
            this.cmbxAttachedAccount.Enabled = false;
            this.cmbxAttachedAccount.FormattingEnabled = true;
            this.cmbxAttachedAccount.Location = new System.Drawing.Point(231, 438);
            this.cmbxAttachedAccount.Name = "cmbxAttachedAccount";
            this.cmbxAttachedAccount.Size = new System.Drawing.Size(121, 28);
            this.cmbxAttachedAccount.TabIndex = 4;
            this.cmbxAttachedAccount.SelectedIndexChanged += new System.EventHandler(this.cmbxAttachedAccount_SelectedIndexChanged);
            // 
            // btnSaveAndReturn
            // 
            this.btnSaveAndReturn.Location = new System.Drawing.Point(231, 536);
            this.btnSaveAndReturn.Name = "btnSaveAndReturn";
            this.btnSaveAndReturn.Size = new System.Drawing.Size(335, 31);
            this.btnSaveAndReturn.TabIndex = 5;
            this.btnSaveAndReturn.Text = "Save And Return To Main";
            this.btnSaveAndReturn.UseVisualStyleBackColor = true;
            this.btnSaveAndReturn.Click += new System.EventHandler(this.btnSaveAndReturn_Click);
            // 
            // tbxOwnerNumber
            // 
            this.tbxOwnerNumber.Location = new System.Drawing.Point(465, 374);
            this.tbxOwnerNumber.Name = "tbxOwnerNumber";
            this.tbxOwnerNumber.Size = new System.Drawing.Size(100, 26);
            this.tbxOwnerNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Savings Accounts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOwnerNumber);
            this.Controls.Add(this.btnSaveAndReturn);
            this.Controls.Add(this.cmbxAttachedAccount);
            this.Controls.Add(this.rbChecking);
            this.Controls.Add(this.rbSavings);
            this.Controls.Add(this.cmbxOwner);
            this.Controls.Add(this.tbxAccountNumber);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.ComboBox cmbxOwner;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.RadioButton rbChecking;
        private System.Windows.Forms.ComboBox cmbxAttachedAccount;
        private System.Windows.Forms.Button btnSaveAndReturn;
        private System.Windows.Forms.TextBox tbxOwnerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}