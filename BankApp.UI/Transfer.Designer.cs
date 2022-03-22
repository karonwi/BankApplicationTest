namespace BankApp.UI
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.chooseAcctLbl = new System.Windows.Forms.Label();
            this.receiversAcctNumLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountTextArea = new System.Windows.Forms.TextBox();
            this.receiverAcctNumberTextArea = new System.Windows.Forms.TextBox();
            this.chooseAcctComboBox = new System.Windows.Forms.ComboBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseAcctLbl
            // 
            this.chooseAcctLbl.AutoSize = true;
            this.chooseAcctLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseAcctLbl.Location = new System.Drawing.Point(98, 247);
            this.chooseAcctLbl.Name = "chooseAcctLbl";
            this.chooseAcctLbl.Size = new System.Drawing.Size(178, 27);
            this.chooseAcctLbl.TabIndex = 0;
            this.chooseAcctLbl.Text = "Choose Accounts :";
            // 
            // receiversAcctNumLbl
            // 
            this.receiversAcctNumLbl.AutoSize = true;
            this.receiversAcctNumLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiversAcctNumLbl.Location = new System.Drawing.Point(98, 357);
            this.receiversAcctNumLbl.Name = "receiversAcctNumLbl";
            this.receiversAcctNumLbl.Size = new System.Drawing.Size(276, 27);
            this.receiversAcctNumLbl.TabIndex = 1;
            this.receiversAcctNumLbl.Text = "Receiver\'s Account Number :";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountLbl.Location = new System.Drawing.Point(98, 124);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(98, 27);
            this.amountLbl.TabIndex = 2;
            this.amountLbl.Text = "Amount :";
            // 
            // amountTextArea
            // 
            this.amountTextArea.Location = new System.Drawing.Point(406, 124);
            this.amountTextArea.Name = "amountTextArea";
            this.amountTextArea.PlaceholderText = "Transfer Amount";
            this.amountTextArea.Size = new System.Drawing.Size(255, 27);
            this.amountTextArea.TabIndex = 3;
            // 
            // receiverAcctNumberTextArea
            // 
            this.receiverAcctNumberTextArea.Location = new System.Drawing.Point(406, 359);
            this.receiverAcctNumberTextArea.Name = "receiverAcctNumberTextArea";
            this.receiverAcctNumberTextArea.PlaceholderText = "Account Number";
            this.receiverAcctNumberTextArea.Size = new System.Drawing.Size(255, 27);
            this.receiverAcctNumberTextArea.TabIndex = 4;
            // 
            // chooseAcctComboBox
            // 
            this.chooseAcctComboBox.FormattingEnabled = true;
            this.chooseAcctComboBox.Location = new System.Drawing.Point(406, 246);
            this.chooseAcctComboBox.Name = "chooseAcctComboBox";
            this.chooseAcctComboBox.Size = new System.Drawing.Size(255, 28);
            this.chooseAcctComboBox.TabIndex = 5;
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.transferButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferButton.Location = new System.Drawing.Point(649, 392);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(128, 46);
            this.transferButton.TabIndex = 6;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.chooseAcctComboBox);
            this.Controls.Add(this.receiverAcctNumberTextArea);
            this.Controls.Add(this.amountTextArea);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.receiversAcctNumLbl);
            this.Controls.Add(this.chooseAcctLbl);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseAcctLbl;
        private System.Windows.Forms.Label receiversAcctNumLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox amountTextArea;
        private System.Windows.Forms.TextBox receiverAcctNumberTextArea;
        private System.Windows.Forms.ComboBox chooseAcctComboBox;
        private System.Windows.Forms.Button transferButton;
    }
}