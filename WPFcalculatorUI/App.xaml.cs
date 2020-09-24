using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFcalculatorUI.Services;

namespace WPFcalculatorUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ICalculationService _calculationService;

        private void App_Startup(object sender, StartupEventArgs e)
        {
            _calculationService = new CalculationService();
            //IKernel kernal = new StandardKernel();
            //kernal.Bind<ICalculationService>().To<CalculationService>();

            MainWindow = new MainWindow(_calculationService);
            MainWindow.Show();
        }
    }
}
