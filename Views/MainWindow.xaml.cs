using System;
using System.Linq;
using System.Windows;
using Ga.Services;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using Ga.Views;
using Ga.ViewModels;


namespace Ga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Si la BDD n'existe pas, on la crée
            using (var db = new DB())
            {
                if (db.Database.EnsureCreated())
                {
                    new Seeds();
                }
            }
        
           
   

            InitializeComponent();
        
        }


    }
}
