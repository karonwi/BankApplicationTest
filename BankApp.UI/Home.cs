using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void createAcctBtn_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount(null,null,null);
            createAccount.ShowDialog();

        }
    }
}
