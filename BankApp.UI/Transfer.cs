using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Interfaces;

namespace BankApp.UI
{
    public partial class Transfer : Form
    {
        private readonly IAccountOperation _accountOperation;
        private readonly IAccount _account;
        public Transfer(IAccount account, IAccountOperation accountOperation)
        {
            InitializeComponent();
            _accountOperation = accountOperation;
            _account = account;
        }

        private async void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool deposit = await _accountOperation.Withdraw(chooseAcctComboBox.Text, amountTextArea.Text);
                if (deposit)
                {
                    bool withdraw = await _accountOperation.Deposit(receiverAcctNumberTextArea.Text,amountTextArea.Text);
                    if (withdraw)
                    {
                        MessageBox.Show("Transfer is successful");
                    }
                    else
                    {
                        await _accountOperation.Deposit(chooseAcctComboBox.Text, amountTextArea.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficent fund");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }

        private async void Transfer_Load(object sender, EventArgs e)
        {
            chooseAcctComboBox.Items.Clear();
            var accounts = await _account.GetAllAccountByCustomer(GlobalVariable.GlobalCustomer.Id);
            if (accounts != null)
            {
                foreach (var item in accounts)
                {
                    chooseAcctComboBox.Items.Add(item.AccountNumber);

                }
            }
        }
    }
}
