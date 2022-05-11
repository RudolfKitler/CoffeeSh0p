using System;
using System.Collections;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CoffeeSh0p
{
    /// <summary>
    /// Логика взаимодействия для ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public int sum, price, orprice;
        public ItemWindow(string selectedDrink, string volume, string imageSource, int pricetg)
        {
            InitializeComponent();
            
            drink.Text = selectedDrink;
            price = pricetg;
            orprice = pricetg;
            vol.Text = volume;
            picture.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            CalculateAmount();
        }

        private void btn_Num_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MinNum_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);
            
            if (i > 0)
                i--;
                btn_Num.Content = i;
            if (i == 0) { BtnAdd.IsEnabled = false; }
            CalculateAmount();
            
        }

        private void Btn_PlusNum_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);
            if (i < 99)
                btn_Num.Content = i + 1;
            CalculateAmount();
            BtnAdd.IsEnabled = true;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CalculateAmount()
        {

            if (ToggleSirop.IsChecked == true) { price += 15; Amount.Content = price * Convert.ToInt16(btn_Num.Content); price = orprice; }
            else Amount.Content = price * Convert.ToInt16(btn_Num.Content);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = drink.Text;
            short price = 200;
            string sugar = "без сахара";
            if (ToggleSugar.IsChecked == true) { sugar = "с сахаром"; } 
            string cinnamon = "без корицы";
            if (ToggleCinnamon.IsChecked == true) { cinnamon = "с корицей"; } 
            string sirop = "без сиропа";
            if (ToggleSirop.IsChecked == true) { sirop = "с сиропом"; } 
            if (ToggleSirop.IsChecked == true) price += 15;
            if (Convert.ToString(btn_Num.Content) != "0")
            {
                Coffee coffee = new Coffee(Convert.ToInt16(btn_Num.Content), selectedDrink, price, sugar, cinnamon, sirop);
                Controller.AddInList(coffee);
                
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
             
            }

        
        private void ToggleSirop_Click(object sender, RoutedEventArgs e)
        {
            CalculateAmount();
        }
    }
}
