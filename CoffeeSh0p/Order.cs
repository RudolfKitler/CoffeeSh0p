using System;
using System.Collections;

namespace CoffeeSh0p
{
    public class Order
    {
        private string orderdate;
        public string Orderdate 
        { 
          get { return orderdate; } 
          set { orderdate = value; }
        }
        private string clientname;
        public string ClientName 
        { 
            get { return clientname; } 
            set { clientname = value; } 
        }
        private string typeofDelivery;

        public string TypeOfDelivery
        {
            get { return typeofDelivery; }
            set { typeofDelivery = value; }
        }
        private int orderBill;

        public int OrderBill
        {
            get { return orderBill; }
            set { orderBill = value; }
        }

        
        private string drinks;
        public string Drinks
        {
            get { return drinks; }
            set { drinks = value; }
        }

        public Order(string coff, int bill, string v1, string now, string v2)
        {
            drinks = coff;
            OrderBill = bill;
            TypeOfDelivery = v1;
            Orderdate = now;
            ClientName = v2;
        }

    }
}
