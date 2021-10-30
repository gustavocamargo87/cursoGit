using System;
using System.Globalization;

namespace Exercicio05 {
    class Program {
        static void Main(string[] args) {
            string[] vet1, vet2;            
            int qtdPeca1, qtdPeca2;
            double valorUnitarioPeca1, valorUnitarioPeca2;
            double valorPeca1, valorPeca2;
            double valorTotal;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            qtdPeca1 = int.Parse(vet1[1]);
            valorUnitarioPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            valorPeca1 = qtdPeca1 * valorUnitarioPeca1;

            qtdPeca2 = int.Parse(vet2[1]);
            valorUnitarioPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            valorPeca2 = qtdPeca2 * valorUnitarioPeca2;

            valorTotal = valorPeca1 + valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
