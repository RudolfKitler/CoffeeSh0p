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

namespace CoffeeSh0p
{
    /// <summary>
    /// Логика взаимодействия для ResponseWindow.xaml
    /// </summary>
    public partial class ResponseWindow : Window
    {
        public ResponseWindow(string res)
        {
            InitializeComponent();
            ResponseView.Text = res;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
