using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using Ga.Views;

namespace Ga
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            //RegisterUriScheme();

            //FormerWindow fm = new();
            //fm.Show();

            //LoginWindow loginW = new();
            //loginW.Show();

            MainWindow mainWindow = new();
            mainWindow.Show();

        }



        const string UriScheme = "ga";
        const string FriendlyName = "Ga Protocol";

        public static void RegisterUriScheme()
        {
            using (var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\" + UriScheme))
            {
                string applicationLocation = @"C:\Users\widoo\source\repos\Ga\bin\Debug\net5.0-windows\Ga.exe";

                key.SetValue("", "URL:" + FriendlyName);
                key.SetValue("URL Protocol", "");

                using (var defaultIcon = key.CreateSubKey("DefaultIcon"))
                {
                    defaultIcon.SetValue("", applicationLocation + ",-1");
                }

                using (var commandKey = key.CreateSubKey(@"shell\open\command"))
                {
                    commandKey.SetValue("", "\"" + applicationLocation + "\" \"%1\"");
                }
            }
        }

    }
}
