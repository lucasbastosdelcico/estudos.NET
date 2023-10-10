using System.Globalization;

namespace Properties
{
    public class ContaBancaria
    {
        public string? Nome { get; set; }

        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }


        public ContaBancaria(string nome, int numConta)
        {
            Nome = nome;
            NumeroConta = numConta;
        }
        public ContaBancaria(string nome, int numConta, double depositoInicial) : this(nome, numConta)
        {
            Deposito(depositoInicial);
        }

        public ContaBancaria() { }
        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular {Nome},saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saldo)
        {
            Saldo -= (saldo + 5.00);
        }
    }
}
