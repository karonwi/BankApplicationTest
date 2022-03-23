using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Commons;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.UI
{
    public partial class GetAccount : Form
    {
        private readonly IUtilities _utilities;
        private readonly IAccount _account;
        public GetAccount(IUtilities utilities, IAccount account)
        {
            _utilities = utilities;
            _account = account;
            InitializeComponent();
        }

        private void initailAmountLbl_Click(object sender, EventArgs e)
        {

        }

        private async void Add_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                AccountNumber = _utilities.RandomDigits(11),
                AccountType = savingsRadioBtn.Checked ? "Savings" : "Current",
                Balance = Convert.ToDouble(initAmtTextBox.Text),
                CustomerId = GlobalVariable.GlobalCustomer.Id

            };
            try
            {
                bool check = await _account.AddAccount(account);
                MessageBox.Show("Account Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void savingsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void currentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void initAmtTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
