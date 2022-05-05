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
        public int sum;
        public ItemWindow(string selectedDrink, string volume, string imageSource, int price)
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = drink.Text;
            short price = 200;
            bool sugar = false;
            if (ToggleSugar.IsChecked == true) { sugar = !sugar; } /*else { sugar = false; } */
            bool cinnamon = false;
            if (ToggleCinnamon.IsChecked == true) { cinnamon = !cinnamon; } /*else { cinnamon = false; }*/
            bool sirop = false;
            if (ToggleSirop.IsChecked == true) { sirop = !sirop; } /*else { sirop = false; }*/
            if (sirop) price += 15; 
            if (Convert.ToString(btn_Num.Content) != "0")
            {
             for (int i=0; i < Convert.ToByte(btn_Num.Content); i++)
                {
                    Coffee coffee = new Coffee(selectedDrink, price, sugar, cinnamon, sirop);
                    Controller.AddInList(coffee);
                }
              //for (int i = 0; i < Controller.coffeeList.Count; i++)
              //  { Console.WriteLine(); }
              foreach (Coffee coffee in Controller.coffeeList)
                { Console.WriteLine("{0} {1} {2} {3} {4}", coffee.coffeeName, coffee.price, coffee.sugar, coffee.cinnamon, coffee.sirop); }
            }
        }
    }
}
