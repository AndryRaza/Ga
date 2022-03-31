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
         
            if(e.Args.Length > 0)
            {
                MainWindow window = new();
                window.Show();
            }
            else
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
            }
     

            //Process.Start(new ProcessStartInfo()
            //{
            //    FileName = "Ga.exe",
            //    UseShellExecute = true, // Be sure to set this to true (not the default value on .NET Core)
            //});

        }



        const string UriScheme = "ga";
        const string FriendlyName = "Ga Protocol";

        public static void RegisterUriScheme()
        {
            using (var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\" + UriScheme))
            {
                // Replace typeof(App) by the class that contains the Main method or any class located in the project that produces the exe.
                // or replace typeof(App).Assembly.Location by anything that gives the full path to the exe
                //string applicationLocation = @"C:\Users\widoo\source\repos\Test\bin\Debug\net5.0-windows\Test.exe";
                string applicationLocation = @"C:\Users\widoo\source\repos\Ga\bin\Debug\net5.0-windows\Ga.exe";

                key.SetValue("", "URL:" + FriendlyName);
                key.SetValue("URL Protocol", "");

                using (var defaultIcon = key.CreateSubKey("DefaultIcon"))
                {
                    defaultIcon.SetValue("", applicationLocation + ",1");
                }

                using (var commandKey = key.CreateSubKey(@"shell\open\command"))
                {
                    commandKey.SetValue("", "\"" + applicationLocation + "\" \"%1\"");
                }
            }
        }

    }
}
