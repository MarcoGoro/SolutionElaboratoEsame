using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfHome
{
    /// <summary>
    /// Logica di interazione per RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnAdvances_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            LoginWindow LW = new LoginWindow();
            LW.Show();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
