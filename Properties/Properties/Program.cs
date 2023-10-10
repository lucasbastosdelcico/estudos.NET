using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do Titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial ? (S/N) ");
            char havera = char.Parse(Console.ReadLine());

            if (havera.ToString() == "N" || havera.ToString() == "n")
            {
                conta  = new ContaBancaria(nomeTitular, NumeroConta);
              
            }
            else if (havera.ToString() == "S" || havera.ToString() == "s" )
            {
                Console.Write("Entre com o valor inicial: ");
                double valorInicio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nomeTitular, NumeroConta, valorInicio);
            }
            else
            {
                Console.WriteLine("Erro ao recuperar os dados do usuário");
                conta = new ContaBancaria();
            }

            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);
            Console.Write("Você deseja sacar ou depisitar? (S/D)");
            char saqueOuNao = char.Parse(Console.ReadLine());
           
            if (saqueOuNao.ToString() == "S" || saqueOuNao.ToString() == "s") { 
                Console.WriteLine("Entre com o valor para saque:");
                double saque  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);
            }
            else
            {
                Console.WriteLine("Entre com o valor para deposito:");
                double dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta.Deposito(dep);
            }

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}