using ContratoTrabalho.Entities.Enums;
using ContratoTrabalho.Entities;
using System;
using System.Globalization;

namespace ContratoTrabalho
{
    public class Program
    {
        static void Main(string[] args) {

            Console.Write("Enter deparment´s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level  = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Deparment dept = new Deparment(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contract to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Durations (hours): ");
                int hours = int.Parse(Console.ReadLine());  
                HourContract contract = new HourContract(date,valuePerHour,hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
           string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0,2));

            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Deparment.Name}");

            Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture)} ");

            Console.WriteLine("Clique em qualquer tecla para continuar:");
            Console.ReadLine();
        }
    }
}