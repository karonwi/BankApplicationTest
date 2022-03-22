namespace BankApp.UI
{
    partial class CreateAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.paswordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(73, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(147, 26);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(394, 302);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 26);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(394, 128);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 26);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(83, 264);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(137, 26);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(216, 76);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(181, 27);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTextBox_Validating);
            // 
            // paswordTextBox
            // 
            this.paswordTextBox.Location = new System.Drawing.Point(534, 301);
            this.paswordTextBox.Name = "paswordTextBox";
            this.paswordTextBox.Size = new System.Drawing.Size(181, 27);
            this.paswordTextBox.TabIndex = 6;
            this.paswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(475, 128);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(181, 27);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTextBox_Validating);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(216, 263);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(181, 27);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTextBox_Validating);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.createAccountBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountBtn.Location = new System.Drawing.Point(601, 364);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(114, 61);
            this.createAccountBtn.TabIndex = 9;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.paswordTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox paswordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}