using System.Windows;

namespace CoffeeSh0p
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Капучино";
            string volume = "300 мл";
            string imageSource = "/Images/cappuccino.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            this.Close();
            itemWindow.Show();

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Капучино XL";
            string volume = "400 мл";
            string imageSource = "/Images/cappuccino.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            this.Close();
            itemWindow.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Латте";
            string volume = "300 мл";
            string imageSource = "/Images/latte.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            this.Close();
            itemWindow.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Латте XL";
            string volume = "400 мл";
            string imageSource = "/Images/latte.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            this.Close();
            itemWindow.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Мокачино";
            string volume = "300 мл";
            string imageSource = "/Images/mok.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            this.Close();
            itemWindow.Show();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            //string selectedDrink = "Мокачино XL";
            //string volume = "400 мл";
            //string imageSource = "/Images/mok.png";
            //ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource);
            //this.Close();
            //itemWindow.Show();
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
        }
    }
}
