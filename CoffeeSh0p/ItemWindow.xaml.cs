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
    /// Логика взаимодействия для ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public int sum;
        public ItemWindow(string selectedDrink, string volume, string imageSource)
        {
            InitializeComponent();
            //BtnDown.IsEnabled = false;
            drink.Text = selectedDrink;
            vol.Text = volume;
            picture.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
        }

        private void btn_Num_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_MinNum_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);
            if (i > 0)
                btn_Num.Content = i - 1;
        }

        private void btn_PlusNum_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);
            if (i < 99)
                btn_Num.Content = i + 1;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
