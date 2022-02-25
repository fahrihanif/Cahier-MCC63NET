namespace OOP63.Model
{
    public class Cart : Menu
    {
        public int TotalItems { get; set; }

        public Cart(string name, int price, int totalItems)
        {
            Name = name;
            Price = price;
            TotalItems = totalItems;
        }
        public Cart()
        {
        }
    }
}
