using BankApp.Commons;
using BankApp.Implementation;
using BankApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;


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

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            var form = serviceProvider.GetRequiredService<Home>();
            Application.Run(form);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICustomer, CustomerImplementation>()
                .AddScoped<IAccount, AccountImplementation>()
                .AddScoped<ITransaction, TransactionImplementation>()
                .AddScoped<ICustomerInRole, CustomerRoleImplementation>()
                .AddScoped<IReadWriteToJson, ReadWriteToJson>()
                .AddScoped<IAuthentication, AuthImplementation>()
                .AddScoped<IValidators, Validators>()
                .AddScoped<IUtilities, Utilities>()
                .AddScoped<CustomerInterface>()
                .AddScoped<CreateAccount>()
                .AddScoped<AccountStatement>()
                .AddScoped<Transfer>()
                .AddScoped<Home>()
                .AddScoped<Login>();



        }
    }
}
