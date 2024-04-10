using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using TipoProduto.Entities;

namespace TipoProduto
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.Write("Quantos produtos foram comprados? ");
            int qtdProduto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdProduto; i++)
            {
                Console.Write("Produto comum, importado ou usado ? (C/I/U) ");
                char tipoProduto = char.Parse(Console.ReadLine());

                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();


                Console.Write("Valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipoProduto)
                {
                    case 'C':
                        lista.Add(new Product(name, price));
                        break;
                    case 'I':
                        Console.Write("Valor da taixa de importação: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        lista.Add(new ImportedProduct(name, price, customsFee));
                     
                        break;
                    case 'U':
                        Console.Write("Data de compra do produto usado (DD/MM/AAAA): ");
                        DateTime manufacture = DateTime.Parse(Console.ReadLine());
                        lista.Add(new UsedProduct(name, price, manufacture));
                        break;
                    default:
                        Console.WriteLine("Tipo produto invalido");
                        break;
                }
            }

            Console.WriteLine("Tipo produto: ");

            foreach (Product prod in lista ) {

                Console.WriteLine(prod.priceTag(),CultureInfo.InvariantCulture);
            
            }

        }
    }

}