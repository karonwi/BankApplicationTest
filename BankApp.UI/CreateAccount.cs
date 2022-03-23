using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Interfaces;
using BankApp.Models;
using BankApp.Commons;

namespace BankApp.UI
{
    public partial class CreateAccount : Form
    {
        private readonly ICustomer _customer;
        private readonly IUtilities _utility;
        private readonly IValidators _validators;
        private readonly Home _home;
        public CreateAccount(ICustomer customer, IUtilities utility, IValidators validators, Home home)
        {
            _home = home;
            _customer = customer;
            _utility = utility;
            _validators = validators;
            InitializeComponent();
        }

        private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                e.Cancel=true;
                firstNameLabel.Focus();
                errorProviderApp.SetError(firstNameTextBox, "Name should not be left Blank");
            }
            else if (!_validators.CheckName(firstNameTextBox.Text))
            {
                e.Cancel = true;
                firstNameTextBox.Focus();
                errorProviderApp.SetError(firstNameTextBox,"First Name should start with a capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(firstNameTextBox, "");
            }
        }

        private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                e.Cancel = true;
                firstNameLabel.Focus();
                errorProviderApp.SetError(lastNameTextBox, "Name should not be left Blank");
            }
            else if (!_validators.CheckName(lastNameTextBox.Text))
            {
                e.Cancel = true;
                firstNameTextBox.Focus();
                errorProviderApp.SetError(lastNameTextBox, "Last Name should start with a capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(lastNameTextBox, "");
            }
        }

        private void EmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                e.Cancel = true;
                firstNameLabel.Focus();
                errorProviderApp.SetError(emailTextBox, "Email should not be left Blank");
            }
            else if (!_validators.CheckEmail(emailTextBox.Text))
            {
                e.Cancel = true;
                firstNameTextBox.Focus();
                errorProviderApp.SetError(emailTextBox, "Enter a correct Email format");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(emailTextBox, "");
            }
        }

        private void PasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paswordTextBox.Text))
            {
                e.Cancel = true;
                firstNameLabel.Focus();
                errorProviderApp.SetError(paswordTextBox, "Password should not be left Blank");
            }
            else if (!_validators.CheckPassword(paswordTextBox.Text))
            {
                e.Cancel = true;
                firstNameTextBox.Focus();
                errorProviderApp.SetError(paswordTextBox, "Enter a correct password format");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(paswordTextBox, "");
            }
        }

        private async void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid().ToString(),
                FullName = firstNameTextBox.Text + " " + lastNameTextBox.Text,
                Email = emailTextBox.Text,
                Password = _utility.ComputeSha256Hash(paswordTextBox.Text),
            };
            try
            {
                var check = await _customer.AddCustomer(customer);
                if (check)
                {
                    MessageBox.Show("User was successfully added");

                }
                _home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
