namespace BankApp.UI
{
    partial class GetAccount
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
            this.initailAmountLbl = new System.Windows.Forms.Label();
            this.initAmtTextBox = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.Label();
            this.savingsRadioBtn = new System.Windows.Forms.RadioButton();
            this.currentRadioBtn = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initailAmountLbl
            // 
            this.initailAmountLbl.AutoSize = true;
            this.initailAmountLbl.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initailAmountLbl.Location = new System.Drawing.Point(152, 109);
            this.initailAmountLbl.Name = "initailAmountLbl";
            this.initailAmountLbl.Size = new System.Drawing.Size(170, 26);
            this.initailAmountLbl.TabIndex = 0;
            this.initailAmountLbl.Text = "Initial Amount";
            this.initailAmountLbl.Click += new System.EventHandler(this.initailAmountLbl_Click);
            // 
            // initAmtTextBox
            // 
            this.initAmtTextBox.Location = new System.Drawing.Point(322, 108);
            this.initAmtTextBox.Name = "initAmtTextBox";
            this.initAmtTextBox.Size = new System.Drawing.Size(213, 27);
            this.initAmtTextBox.TabIndex = 1;
            this.initAmtTextBox.TextChanged += new System.EventHandler(this.initAmtTextBox_TextChanged);
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountType.Location = new System.Drawing.Point(152, 179);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(170, 26);
            this.accountType.TabIndex = 2;
            this.accountType.Text = "Account Type";
            // 
            // savingsRadioBtn
            // 
            this.savingsRadioBtn.AutoSize = true;
            this.savingsRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savingsRadioBtn.Location = new System.Drawing.Point(356, 182);
            this.savingsRadioBtn.Name = "savingsRadioBtn";
            this.savingsRadioBtn.Size = new System.Drawing.Size(83, 24);
            this.savingsRadioBtn.TabIndex = 3;
            this.savingsRadioBtn.TabStop = true;
            this.savingsRadioBtn.Text = "Savings";
            this.savingsRadioBtn.UseVisualStyleBackColor = true;
            this.savingsRadioBtn.CheckedChanged += new System.EventHandler(this.savingsRadioBtn_CheckedChanged);
            // 
            // currentRadioBtn
            // 
            this.currentRadioBtn.AutoSize = true;
            this.currentRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentRadioBtn.Location = new System.Drawing.Point(452, 183);
            this.currentRadioBtn.Name = "currentRadioBtn";
            this.currentRadioBtn.Size = new System.Drawing.Size(83, 24);
            this.currentRadioBtn.TabIndex = 4;
            this.currentRadioBtn.TabStop = true;
            this.currentRadioBtn.Text = "Current";
            this.currentRadioBtn.UseVisualStyleBackColor = true;
            this.currentRadioBtn.CheckedChanged += new System.EventHandler(this.currentRadioBtn_CheckedChanged);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(615, 375);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 47);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // GetAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.currentRadioBtn);
            this.Controls.Add(this.savingsRadioBtn);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.initAmtTextBox);
            this.Controls.Add(this.initailAmountLbl);
            this.Name = "GetAccount";
            this.Text = "GetAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initailAmountLbl;
        private System.Windows.Forms.TextBox initAmtTextBox;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.RadioButton savingsRadioBtn;
        private System.Windows.Forms.RadioButton currentRadioBtn;
        private System.Windows.Forms.Button Add;
    }
}