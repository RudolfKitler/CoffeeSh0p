namespace CoffeeSh0p
{
    public class Coffee
    {
        public int quantity;
        public string coffeeName;
        public int price;
        public string sugar;
        public string cinnamon;
        public string sirop;
        public Coffee(int quantity, string coffeeName, int price, string sugar, string cinnamon, string sirop)
        {
            this.quantity = quantity;
            this.coffeeName = coffeeName;
            this.price = price;
            this.sugar = sugar;
            this.cinnamon = cinnamon;
            this.sirop = sirop;
        }
    }
}
