using System.Windows;

namespace GUI.QuitAbout
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void AboutOk(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
