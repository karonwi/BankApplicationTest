namespace BankApp.UI
{
    partial class AccountStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountStatement));
            this.dgAccountStatement = new System.Windows.Forms.DataGridView();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseAcctLabel = new System.Windows.Forms.Label();
            this.chooseAccountComboBx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAccountStatement
            // 
            this.dgAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNumber,
            this.Description,
            this.Amount,
            this.RemainBalance,
            this.Date});
            this.dgAccountStatement.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgAccountStatement.Location = new System.Drawing.Point(0, 127);
            this.dgAccountStatement.Name = "dgAccountStatement";
            this.dgAccountStatement.RowHeadersWidth = 51;
            this.dgAccountStatement.RowTemplate.Height = 29;
            this.dgAccountStatement.Size = new System.Drawing.Size(1007, 557);
            this.dgAccountStatement.TabIndex = 2;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "Account Number";
            this.AccountNumber.MinimumWidth = 6;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 180;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 400;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // RemainBalance
            // 
            this.RemainBalance.HeaderText = "Balance";
            this.RemainBalance.MinimumWidth = 6;
            this.RemainBalance.Name = "RemainBalance";
            this.RemainBalance.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // chooseAcctLabel
            // 
            this.chooseAcctLabel.AutoSize = true;
            this.chooseAcctLabel.BackColor = System.Drawing.Color.White;
            this.chooseAcctLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.chooseAcctLabel.Location = new System.Drawing.Point(21, 33);
            this.chooseAcctLabel.Name = "chooseAcctLabel";
            this.chooseAcctLabel.Size = new System.Drawing.Size(200, 26);
            this.chooseAcctLabel.TabIndex = 3;
            this.chooseAcctLabel.Text = "Choose Account";
            // 
            // chooseAccountComboBx
            // 
            this.chooseAccountComboBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseAccountComboBx.FormattingEnabled = true;
            this.chooseAccountComboBx.Location = new System.Drawing.Point(269, 31);
            this.chooseAccountComboBx.Name = "chooseAccountComboBx";
            this.chooseAccountComboBx.Size = new System.Drawing.Size(151, 36);
            this.chooseAccountComboBx.TabIndex = 4;
            this.chooseAccountComboBx.SelectedIndexChanged += new System.EventHandler(this.chooseAccountComboBx_SelectedIndexChanged);
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseAccountComboBx);
            this.Controls.Add(this.chooseAcctLabel);
            this.Controls.Add(this.dgAccountStatement);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.Load += new System.EventHandler(this.AccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccountStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label chooseAcctLabel;
        private System.Windows.Forms.ComboBox chooseAccountComboBx;
    }
}