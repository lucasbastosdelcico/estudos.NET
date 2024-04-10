using System.Globalization;
using System.Reflection.Metadata;

namespace TipoProduto.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string? name, double price, double customsFee) : base(name, price)
        {

            CustomsFee = customsFee;
        }
        public override string priceTag()
        {

            return $" {Name} ${totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double totalPrice()
        {

            return Price += CustomsFee;
        }
    }
}
