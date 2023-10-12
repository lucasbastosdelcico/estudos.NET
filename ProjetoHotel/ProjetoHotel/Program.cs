namespace ProjetoHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            DadosEstudantes[] estudantes = new DadosEstudantes[10];


            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine("Informe o nome do estudante!");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o Email");
                string email = Console.ReadLine();
                Console.WriteLine("Informe o quarto");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new DadosEstudantes(nome, email);
            }
            Console.WriteLine("Quartos Ocupados");

            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }
        }
    }
}