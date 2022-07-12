using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de contribuites: ");
            int n = int.Parse(Console.ReadLine());

            List <Pessoa> pessoas = new List<Pessoa> ();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}: ");
                Console.Write("Pessoa Fisica ou Juridica (f/j) ? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Ganho Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(nome, ganhoAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Ganho Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Número de funcionários:");
                    int qtd = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome,ganhoAnual,qtd));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Contribuiçoes: ");
            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome +
                    ": $ " +
                   pessoa.CalcImposto().ToString("f2",CultureInfo.InvariantCulture));
            }
            double TotalTaxes = 0.0;
            foreach (Pessoa pessoa in pessoas)
            {
                TotalTaxes += pessoa.CalcImposto();
            }
            Console.WriteLine("Total das Contribuições: " + TotalTaxes.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}