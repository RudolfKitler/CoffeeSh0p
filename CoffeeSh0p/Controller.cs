using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace CoffeeSh0p
{
    static class Controller
    {
        public static ArrayList coffeeList = new ArrayList();
        public static void AddInList(Coffee coffee)
        {
            coffeeList.Add(coffee);
        }      
        public static void CollectOrder(string clientName, bool RB, string datetime)
        {
            string drinksListed="";
            foreach (Coffee coffee in Controller.coffeeList)
            {
                drinksListed += "[" + coffee.quantity + "x]" + " " + coffee.coffeeName + ", " + coffee.sugar + ", " + coffee.cinnamon + ", " + coffee.sirop + "\n"; ;
            }
            OrderWindow orderWindow = new OrderWindow();
            string typeOfD;
            if (RB) { typeOfD = "В зале"; } else { typeOfD = "С собой"; }
            Order order = new Order(drinksListed, orderWindow.bill, typeOfD, datetime, clientName);
            SendOrder(order);
        }

        public static void SendOrder(Order order)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.56.1:5000/order");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        drinks = Convert.ToString(order.Drinks),
                        orderBill = order.OrderBill,
                        typeOfDelivery = order.TypeOfDelivery,
                        orderDate = order.Orderdate,
                        clientName = order.ClientName
                    });

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    ResponseWindow responseWindow = new ResponseWindow(result);
                    responseWindow.Show();
                    Controller.coffeeList.Clear();
                }
            }
            catch (Exception)
            {
                var result = "Что-то пошло не так...\nПопробуйте позже";
                ResponseWindow responseWindow = new ResponseWindow(result);
                responseWindow.Show();
            }

        }
    }
}
