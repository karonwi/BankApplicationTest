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
        private readonly CreateAccount _createAccount;
        private readonly Login _loginAccount;
        public Home(CreateAccount account, Login loginAccount)
        {
            _loginAccount = loginAccount;
            _createAccount = account;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            _loginAccount.ShowDialog();
        }

        private void createAcctBtn_Click(object sender, EventArgs e)
        {
            _createAccount.ShowDialog();

        }
    }
}
