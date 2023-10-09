namespace CalculaDolar{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar ? ");
            calculadoraDolar.ValorDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            calculadoraDolar.ValorAComprarDolar = double.Parse(Console.ReadLine());

            double total = calculadoraDolar.CalculaValorDolar();
            Console.WriteLine($"Valor a ser pago em reais é : R$ {total}");
        }

    }
}