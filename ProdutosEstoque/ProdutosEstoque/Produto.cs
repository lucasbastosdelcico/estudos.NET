
namespace ProdutosEstoque
{
    public  class Produto
    {
       public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
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
