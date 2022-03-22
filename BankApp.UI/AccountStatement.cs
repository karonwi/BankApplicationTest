using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.UI
{
    public partial class AccountStatement : Form
    {
        private readonly IAccount _account;
        private readonly ITransaction _transaction;
        public AccountStatement(ITransaction transaction, IAccount account)
        {
            _transaction = transaction;
            _account = account;
            InitializeComponent();
        }

        private async void chooseAccountComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseAccountComboBx.Text != "")
            {
                dgAccountStatement.Rows.Clear();
                var trans = await _transaction.GetAllTransactionsForAnAccount(chooseAccountComboBx.Text);
                if (trans != null)
                {
                    foreach (var item in trans)
                    {
                        string[] row = new string[5];
                        row[0] = item.AccountNumber;
                        row[1] = item.Description;
                        row[2] = item.Amount;
                        row[3] = item.Balance;
                        row[4] = item.Date.ToString();

                        dgAccountStatement.Rows.Add(row);

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an Account");
            }
        }

        private async void AccountStatement_Load(object sender, EventArgs e)
        {
            chooseAccountComboBx.Items.Clear();
            var account = await _account.GetAllAccountByCustomer(GlobalVariable.GlobalCustomer.Id);
            if (account != null)
            {
                foreach (var item in account)
                {
                    chooseAccountComboBx.Items.Add(item.AccountNumber);
                }
            }

        }
    }
}
