using System.Globalization;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produto");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            
            for (int i = 0; i < n; i++) {
                vect[i] = new Product();
                Console.Write("Digite o Nome: ");
                vect[i].Name = Console.ReadLine();
                Console.Write("Digite o preço: ");
                vect[i].Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double result = soma / n;

            Console.WriteLine($"AVERAGE PRICE = {result.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}