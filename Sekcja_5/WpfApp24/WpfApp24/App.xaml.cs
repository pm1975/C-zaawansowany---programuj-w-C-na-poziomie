using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp24.Database;
using WpfApp24.Domain;
using WpfApp24.Services;

namespace WpfApp24
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IDataStoreManager, DataStoreManager>();
            serviceCollection.AddTransient<ICalculatorManager, CalculatorManager>();
        }
    }
}
