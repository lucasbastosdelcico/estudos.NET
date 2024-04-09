using SistemaDePagamentos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SistemaDePagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();

            Console.Write("Entre com a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Empregado #{i} dados: ");
                Console.Write("Funcionário terceirizado ? (S/N): ");
                char eTerceirizado = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (eTerceirizado == 'S')
                {
                    Console.Write("Adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    lista.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");

            foreach (Employee emp in lista)
            {
                Console.WriteLine($"{emp.name}, horas trabalhadas: {emp.payment().ToString("F2",CultureInfo.InvariantCulture)},");
            }

        }
    }
}