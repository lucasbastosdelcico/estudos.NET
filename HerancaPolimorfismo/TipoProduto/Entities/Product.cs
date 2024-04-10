using System.Globalization;

namespace TipoProduto.Entities
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string? name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {

            return $@"Nome: {Name} Preço: {Price.ToString("F2",CultureInfo.InvariantCulture)}
            ";
        }
    }
}
