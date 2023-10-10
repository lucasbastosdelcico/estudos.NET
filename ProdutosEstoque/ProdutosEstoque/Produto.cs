
using System.Runtime.InteropServices;

namespace ProdutosEstoque
{
    public class Produto
    {
        public  string? Nome;
        public  double Preco;
        public  int Quantidade;

         public Produto(){}

        public double TotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
        }
        public void AdicionarProdutos(int quantity) {
            Quantidade = Quantidade + quantity;
        }
        public void RemoverProdutos(int quantity)
        {
              Quantidade = Quantidade - quantity;
        }
       
    }
}
