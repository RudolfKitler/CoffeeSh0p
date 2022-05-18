using HandyControl.Tools;
using System;
using System.Collections;
using System.Windows;

namespace CoffeeSh0p
{

    public partial class OrderWindow : Window
    {
        public int bill = 0;
       
        DateTime DateStart;
        
        public OrderWindow()
        {
            InitializeComponent();
            ConfigHelper.Instance.SetLang("ru");
            DateStart = DateTime.Today;
            if (DateTime.Now > Convert.ToDateTime("21:00")) DateStart = DateTime.Today.AddDays(1);
            DP.DisplayDateStart = DateStart;
            DP.Text = DateStart.ToString();


            TimeList();
            ComboTime.SelectedIndex = 0;
            Fill();
           
        }
        public void Fill()
        {
            Cart.Items.Clear();
            bill = 0;
            foreach (Coffee coffee in Controller.coffeeList)
            {
                bill += coffee.quantity * coffee.price;
            }
            labelBill.Content = Convert.ToString(bill) + "₽";
            foreach (Coffee coffee in Controller.coffeeList)
                Cart.Items.Add("[" + coffee.quantity + "x]" + " " + coffee.coffeeName + ",\n " + coffee.sugar + ", " + coffee.cinnamon + ", " + coffee.sirop);
        }
        public void TimeList()
        {
            ArrayList arrTime = new ArrayList()
            {
                "08:00", "08:05", "08:10", "08:15", "08:20", "08:25", "08:30", "08:35", "08:40", "08:45", "08:50", "08:55",
                "09:00", "09:05", "09:10", "09:15", "09:20", "09:25", "09:30", "09:35", "09:40", "09:45", "09:50", "09:55",
                "10:00", "10:05", "10:10", "10:15", "10:20", "10:25", "10:30", "10:35", "10:40", "10:45", "10:50", "10:55",
                "11:00", "11:05", "11:10", "11:15", "11:20", "11:25", "11:30", "11:35", "11:40", "11:45", "11:50", "11:55",
                "12:00", "12:05", "12:10", "12:15", "12:20", "12:25", "12:30", "12:35", "12:40", "12:45", "12:50", "12:55",
                "13:00", "13:05", "13:10", "13:15", "13:20", "13:25", "13:30", "13:35", "13:40", "13:45", "13:50", "13:55",
                "14:00", "14:05", "14:10", "14:15", "14:20", "14:25", "14:30", "14:35", "14:40", "14:45", "14:50", "14:55",
                "15:00", "15:05", "15:10", "15:15", "15:20", "15:25", "15:30", "15:35", "15:40", "15:45", "15:50", "15:55",
                "16:00", "16:05", "16:10", "16:15", "16:20", "16:25", "16:30", "16:35", "16:40", "16:45", "16:50", "16:55",
                "17:00", "17:05", "17:10", "17:15", "17:20", "17:25", "17:30", "17:35", "17:40", "17:45", "17:50", "17:55",
                "18:00", "18:05", "18:10", "18:15", "18:20", "18:25", "18:30", "18:35", "18:40", "18:45", "18:50", "18:55",
                "19:00", "19:05", "19:10", "19:15", "19:20", "19:25", "19:30", "19:35", "19:40", "19:45", "19:50", "19:55",
                "20:00", "20:05", "20:10", "20:15", "20:20", "20:25", "20:30", "20:35", "20:40", "20:45", "20:50", "20:55",
                "21:00"
            };
            if (DateStart == DateTime.Today)
            {
                for (int i = 0; i < arrTime.Count; i++)
                {
                    if (DateTime.Now.AddMinutes(5) > Convert.ToDateTime(arrTime[i]))
                    {
                        arrTime.RemoveAt(i);
                        i = -1;
                    }
                }
            }

            ComboTime.Items.Clear();
            for (int i = 0; i < arrTime.Count; i++)
                ComboTime.Items.Add(arrTime[i]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ComboTime.SelectedIndex < ComboTime.Items.Count) ComboTime.SelectedIndex++;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ComboTime.SelectedIndex != 0) ComboTime.SelectedIndex--;
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (TBclientName.Text == "") { TBclientName.Focus(); }
            else if (DP.Text == "") { DP.Focus(); }
            else 
            {
                string DT = DP.Text + " " + ComboTime.Text;
                Console.WriteLine(DT);
                Controller.CollectOrder(TBclientName.Text, RbTable.IsChecked == true, DT);
                this.Close();
            }
        }

        private void BtnEraseList_Click(object sender, RoutedEventArgs e)
        {
            Controller.coffeeList.Clear();
            Cart.Items.Clear();
            BtnOrder.IsEnabled = false;
            labelBill.Content = "0₽";
            BtnRemoveElement.Visibility = Visibility.Hidden;

        }

        private void BtnRemoveElement_Click(object sender, RoutedEventArgs e)
        {
            if (Cart.Items.Count != 0)
            {
                int f = Cart.SelectedIndex;
                if (f >= 0 && f < Cart.Items.Count)
                {
                    Controller.coffeeList.RemoveAt(f);
                    Fill();
                }
            }
            if (Cart.Items.Count == 0) { 
                BtnOrder.IsEnabled = false;
                labelBill.Content = "0₽";
                BtnRemoveElement.Visibility = Visibility.Hidden;
                
            }

        }
    }
}
