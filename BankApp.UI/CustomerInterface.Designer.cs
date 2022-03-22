namespace BankApp.UI
{
    partial class CustomerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            this.createAcctBtn = new System.Windows.Forms.Button();
            this.accountStatementBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.acctNumComboBox = new System.Windows.Forms.ComboBox();
            this.amountDepWith = new System.Windows.Forms.Label();
            this.amountTextArea = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.balanceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAcctBtn
            // 
            this.createAcctBtn.BackColor = System.Drawing.Color.Moccasin;
            this.createAcctBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAcctBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createAcctBtn.Location = new System.Drawing.Point(43, 22);
            this.createAcctBtn.Name = "createAcctBtn";
            this.createAcctBtn.Size = new System.Drawing.Size(94, 57);
            this.createAcctBtn.TabIndex = 0;
            this.createAcctBtn.Text = "Create Account";
            this.createAcctBtn.UseVisualStyleBackColor = false;
            // 
            // accountStatementBtn
            // 
            this.accountStatementBtn.BackColor = System.Drawing.Color.Moccasin;
            this.accountStatementBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountStatementBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.accountStatementBtn.Location = new System.Drawing.Point(673, 22);
            this.accountStatementBtn.Name = "accountStatementBtn";
            this.accountStatementBtn.Size = new System.Drawing.Size(94, 57);
            this.accountStatementBtn.TabIndex = 1;
            this.accountStatementBtn.Text = "Account Statement";
            this.accountStatementBtn.UseVisualStyleBackColor = false;
            this.accountStatementBtn.Click += new System.EventHandler(this.AccountStatementBtn_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.Moccasin;
            this.transferBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transferBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.transferBtn.Location = new System.Drawing.Point(509, 22);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(94, 57);
            this.transferBtn.TabIndex = 2;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.BackColor = System.Drawing.Color.Moccasin;
            this.withdrawalBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawalBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.withdrawalBtn.Location = new System.Drawing.Point(353, 22);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(94, 57);
            this.withdrawalBtn.TabIndex = 3;
            this.withdrawalBtn.Text = "Withdraw";
            this.withdrawalBtn.UseVisualStyleBackColor = false;
            this.withdrawalBtn.Click += new System.EventHandler(this.WithdrawalBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.Moccasin;
            this.depositBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.depositBtn.Location = new System.Drawing.Point(191, 22);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(94, 57);
            this.depositBtn.TabIndex = 4;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountNumberLbl.Location = new System.Drawing.Point(43, 138);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(200, 26);
            this.accountNumberLbl.TabIndex = 5;
            this.accountNumberLbl.Text = "Account Number :";
            // 
            // acctNumComboBox
            // 
            this.acctNumComboBox.FormattingEnabled = true;
            this.acctNumComboBox.Location = new System.Drawing.Point(240, 136);
            this.acctNumComboBox.Name = "acctNumComboBox";
            this.acctNumComboBox.Size = new System.Drawing.Size(195, 28);
            this.acctNumComboBox.TabIndex = 6;
            this.acctNumComboBox.SelectedIndexChanged += new System.EventHandler(this.AcctNumComboBox_SelectedIndexChanged);
            // 
            // amountDepWith
            // 
            this.amountDepWith.AutoSize = true;
            this.amountDepWith.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountDepWith.Location = new System.Drawing.Point(43, 213);
            this.amountDepWith.Name = "amountDepWith";
            this.amountDepWith.Size = new System.Drawing.Size(107, 26);
            this.amountDepWith.TabIndex = 7;
            this.amountDepWith.Text = "Amount :";
            // 
            // amountTextArea
            // 
            this.amountTextArea.Location = new System.Drawing.Point(240, 213);
            this.amountTextArea.Name = "amountTextArea";
            this.amountTextArea.PlaceholderText = "Deposit/Withdrawal/Transfer Amount";
            this.amountTextArea.Size = new System.Drawing.Size(195, 27);
            this.amountTextArea.TabIndex = 8;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balance.Location = new System.Drawing.Point(43, 303);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(107, 26);
            this.balance.TabIndex = 9;
            this.balance.Text = "Balance :";
            // 
            // balanceRichTextBox
            // 
            this.balanceRichTextBox.Location = new System.Drawing.Point(240, 303);
            this.balanceRichTextBox.Name = "balanceRichTextBox";
            this.balanceRichTextBox.Size = new System.Drawing.Size(195, 46);
            this.balanceRichTextBox.TabIndex = 10;
            this.balanceRichTextBox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButton.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(656, 381);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 57);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Gray;
            this.logOutBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOutBtn.Location = new System.Drawing.Point(43, 394);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(94, 57);
            this.logOutBtn.TabIndex = 12;
            this.logOutBtn.Text = "LOGOUT";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.balanceRichTextBox);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.amountTextArea);
            this.Controls.Add(this.amountDepWith);
            this.Controls.Add(this.acctNumComboBox);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.withdrawalBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.accountStatementBtn);
            this.Controls.Add(this.createAcctBtn);
            this.Name = "CustomerInterface";
            this.Text = "CustomerInterface";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAcctBtn;
        private System.Windows.Forms.Button accountStatementBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button withdrawalBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.ComboBox acctNumComboBox;
        private System.Windows.Forms.Label amountDepWith;
        private System.Windows.Forms.TextBox amountTextArea;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.RichTextBox balanceRichTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button logOutBtn;
    }
}