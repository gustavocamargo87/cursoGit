using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (b == 0) {
                    Console.WriteLine("divisão impossível");
                }
                else {
                    double divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
