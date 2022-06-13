using System.Collections.Generic;
namespace OnlineShop.Models
{
    public class Product
    {
        public string Title { get; private set; }
        public int Price { get; private set; }
        public string Producer { get; private set; }
        public string Type { get; private set; }
        public int Amount { get; private set; }

        public Product(string title, int price, string producer, string type, int amount)
        {
            Title = title;
            Price = price;
            Producer = producer;
            Type = type;
            Amount = amount;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product("Chicken", 3884, "Voonyx", "In felis", 378),
                new Product("Kippers", 7499, "Skipfire", "Mi", 207),
                new Product("Pork", 2191, "Tagtune", "Nisl", 186),
                new Product("Soup", 6631, "Yodoo", "Scelerisque quam", 128),
                new Product("Sweater", 8836, "Skinix", "Quis", 496),
                new Product("Trueblue", 4009, "Skipfire", "Nunc", 338),
                new Product("Truffle Cups", 1740, "Tagtune", "Aenean auctor", 441),
                new Product("Quail", 9223, "Voonyx", "Eget", 111),
                new Product("Seedlings", 6154, "Skipfire", "Quisque", 302),
                new Product("Lettuce", 2239, "Tagtune", "Diam nam", 132)
            };

            return products;
        }
    }
}
