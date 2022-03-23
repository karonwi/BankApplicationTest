using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankApp.UI
{
    public partial class CustomerInterface : Form
    {
        private readonly IAccount _account;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccountOperation _accountOperation;
        private readonly GetAccount _getAccount;
        public CustomerInterface(IAccount account, IServiceProvider serviceProvider, IAccountOperation accountOperation,GetAccount getAccount)
        {
            _getAccount = getAccount;
            _account = account;
            _serviceProvider = serviceProvider;
            _accountOperation = accountOperation;
            InitializeComponent();
        }

        private async void CustomerInterface_Load(object sender, EventArgs e)
        {
            var accounts = await _account.GetAllAccountByCustomer(GlobalVariable.GlobalCustomer.Id);
            if (accounts != null)
            {
                foreach (var item in accounts)
                {
                    acctNumComboBox.Items.Add(item.AccountNumber);
                }
            }
        }

        private async void AcctNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = acctNumComboBox.Text;
            var account = await _account.GetAccountDetails(selected);

            if (account != null)
            {
                balanceRichTextBox.Text = account.Balance.ToString();
            }
        }

        private async void DepositBtn_Click(object sender, EventArgs e)
        {
            if (acctNumComboBox.Text != "" && amountTextArea.Text != "")
            {
                bool check = await _accountOperation.Deposit(acctNumComboBox.Text, amountTextArea.Text);
                if (check)
                {
                    MessageBox.Show("Deposit was successful");
                }
                else
                {
                    MessageBox.Show("Please select an Account Number");
                }
            }
        }

        private async void WithdrawalBtn_Click(object sender, EventArgs e)
        {
            if (acctNumComboBox.Text != "" && amountTextArea.Text != "")
            {
                bool check = await _accountOperation.Withdraw(acctNumComboBox.Text, amountTextArea.Text);
                if(check)
                {
                    MessageBox.Show("Withdraw was successful");
                }
                else
                {
                    MessageBox.Show("Insufficient fund");
                }
            }
            else
            {
                MessageBox.Show("Please select an Account Number");
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            Transfer transfer = _serviceProvider.GetRequiredService<Transfer>();
            transfer.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            amountTextArea.Text = "";
        }

        private void AccountStatementBtn_Click(object sender, EventArgs e)
        {
            AccountStatement account = _serviceProvider.GetRequiredService<AccountStatement>();
            account.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void createAcctBtn_Click(object sender, EventArgs e)
        {
            _getAccount.Show();

        }
    }
}
