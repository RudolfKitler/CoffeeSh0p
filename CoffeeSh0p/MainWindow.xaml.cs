using System.Windows;

namespace CoffeeSh0p
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Controller.coffeeList.Count != 0) { BtnGetOrder.IsEnabled = true; }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Капучино";
            string volume = "300 мл";
            int price = 200;
            string imageSource = "/Images/cappuccino.png";
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Капучино XL";
            string volume = "400 мл";
            string imageSource = "/Images/cappuccino.png";
            int price = 200;
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Латте";
            string volume = "300 мл";
            string imageSource = "/Images/latte.png";
            int price = 200;
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Латте XL";
            string volume = "400 мл";
            string imageSource = "/Images/latte.png";
            int price = 200;
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Мокачино";
            string volume = "300 мл";
            string imageSource = "/Images/mok.png";
            int price = 200;
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            string selectedDrink = "Мокачино XL";
            string volume = "400 мл";
            string imageSource = "/Images/mok.png";
            int price = 200;
            ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
            itemWindow.Show();
            this.Close();
        }
         private void Btn7_Click(object sender, RoutedEventArgs e)
                {
                    string selectedDrink = "Флэт Уайт";
                    string volume = "200 мл";
                    string imageSource = "/Images/flatwhite.png";
                    int price = 190;
                    ItemWindow itemWindow = new ItemWindow(selectedDrink, volume, imageSource, price);
                    itemWindow.Show();
                    this.Close();
                }
        private void BtnGetOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       
    }
}
