using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Ga.ViewModels;


namespace Ga.Views
{
    /// <summary>
    /// Logique d'interaction pour Former.xaml
    /// </summary>
    public partial class FormerWindow : Window
    {

        readonly FormerViewModel fvm = new();
        public FormerWindow()
        {
            DataContext = fvm;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fvm.getStudents();
            DG1.ItemsSource = fvm.UsersPromotion;
        }

    }
}
