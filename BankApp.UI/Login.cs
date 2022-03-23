using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApp.Interfaces;
using BankApp.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BankApp.UI
{
    public partial class Login : Form
    {
        private readonly IAuthentication _authentication;
        private IServiceProvider _serviceProvider;
        public Login(IAuthentication authentication, IServiceProvider serviceProvider)
        {
            _authentication = authentication;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var customers = await _authentication.Login(emailTextBox.Text, passwordTxtArea.Text);
                if (customers != null)
                {
                    GlobalVariable.GlobalCustomer = customers;

                    this.Hide();
                    CustomerInterface customerInterface= _serviceProvider.GetRequiredService<CustomerInterface>();
                    customerInterface.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
