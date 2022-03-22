using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using BankApp.Interfaces;
using BankApp.Implementation;
using BankApp.Commons;
using Microsoft.Extensions.DependencyInjection;


namespace BankApp.UI
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AccountStatement());
            var services = new ServiceCollection();

            ConfigureServices(services);
            using ( ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<CreateAccount>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICustomer, CustomerImplementation>()
                .AddScoped<IAccount, AccountImplementation>()
                .AddScoped<ITransaction, TransactionImplementation>()
                .AddScoped<ICustomerInRole, CustomerRoleImplementation>()
                .AddScoped<IReadWriteToJson, ReadWriteToJson>()
                .AddScoped<IValidators, Validators>()
                .AddScoped<IUtilities, Utilities>()
                .AddScoped<CustomerInterface>()
                .AddScoped<CreateAccount>()
                .AddScoped<AccountStatement>()
                .AddScoped<Transfer>();
                

        }
    }
}
