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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUI.QuitAbout;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var mainExit = new Quit();
            Close();
            mainExit.Show();
        }

        private void Show_About(object sender, RoutedEventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void Show_Settings(object sender, RoutedEventArgs e)
        {
            var settings = new Settings.Settings();
            Close();
            settings.Show();
        }
    }
}
