using Icomparable.Entities;
using System;

namespace Icomparable { 
     class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\GitHub\estudos.NET\Interface\Icomparable\txt.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) { 

                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream) { 
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach (Employee e in list) { Console.WriteLine(e);}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}