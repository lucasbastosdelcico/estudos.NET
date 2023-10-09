
namespace CalculaDolar
{
    public class calculadoraDolar
    {
        public static double ValorDolar { get; set; }
        public static double ValorAComprarDolar  { get; set; }

        public static double CalculaValorDolar()
        {
            double valorCambio = ValorDolar * ValorAComprarDolar * 0.06 / 100;
           double valorTotal = ValorDolar * ValorAComprarDolar + valorCambio;
            return double.Parse(valorTotal.ToString("F2"));
        }
    }
}
