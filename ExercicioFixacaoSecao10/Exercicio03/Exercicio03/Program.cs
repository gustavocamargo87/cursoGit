using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio03.Entities;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nemmp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, nemmp)); 
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");

            double total = 0;
            foreach (TaxPayer t in list) 
            {
                Console.WriteLine(t.Name + ": $ "  + t.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total += t.Tax();
            }

            Console.WriteLine("");
            Console.Write("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
