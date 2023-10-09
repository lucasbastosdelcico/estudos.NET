using System;
using System.Globalization;

namespace ProdutosEstoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            int novaQuantidade;
            Produto produto = new Produto();

      
            PerguntaProduto();
            produto.Nome = Console.ReadLine();
            produto.Preco = double.Parse(Console.ReadLine());
            produto.Quantidade = int.Parse(Console.ReadLine());
            MostraDadosProduto(produto);
            AdcProduto();
            novaQuantidade= int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(novaQuantidade);
            MostraDadosProdutoAtualizados(produto);
            RemoverProduto();
            novaQuantidade= int.Parse(Console.ReadLine());
            produto.RemoverProdutos(novaQuantidade);
            MostraDadosProdutoAtualizados(produto);
        }
        static void PerguntaProduto()
        {
            Console.WriteLine("Entre os dados do Produto, Nome , Preço e quantidade em estoque.");
        }
        static void MostraDadosProduto(Produto produto)
        {
            Console.WriteLine($"Dados do produto: {produto.Nome}, ${produto.Preco}, {produto.Quantidade} unidades, Total : {produto.TotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}");
        }
        static void AdcProduto()
        {
            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
        }
        static void RemoverProduto()
        {
            Console.Write("Digite o número de produtos a ser removido do estoque:");
        }
        static void MostraDadosProdutoAtualizados(Produto produto)
        {
        
            Console.WriteLine($"Dados atualizados: {produto.Nome}, ${produto.Preco}, {produto.Quantidade} unidades, Total : {produto.TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
       
    }
}