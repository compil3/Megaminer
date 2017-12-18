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

namespace GUI.QuitAbout
{
    /// <summary>
    /// Interaction logic for Quit.xaml
    /// </summary>
    public partial class Quit : Window
    {
        public Quit()
        {
            InitializeComponent();
        }

        private void Quit_Yes(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Quit_No(object sender, RoutedEventArgs e)
        {
            var returnMain = new MainWindow();
            Close();
            returnMain.Show();
        }
    }
}
