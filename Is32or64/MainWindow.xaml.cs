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

namespace Is32or64
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (System.Environment.Is64BitOperatingSystem == true)
            {
                arch.Content = "64 Bits";
            }
            else
            {
                arch.Content = "32 Bits";
            }
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0x1);
        }
    }
}
