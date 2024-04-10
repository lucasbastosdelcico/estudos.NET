using System.Globalization;

namespace TipoProduto.Entities
{
    public class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct() { }

        public UsedProduct(string? name, double price, DateTime manufacture) : base(name, price)
        {

            Manufacture = manufacture;

        }

        public override string priceTag()
        {
            return  $" {Name} (Usado) ${Price.ToString("F2",CultureInfo.InvariantCulture)} (Data de compra: {Manufacture.Date})";
        }
    }
}
