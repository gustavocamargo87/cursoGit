using System;
using System.Globalization;

namespace Exercicio08 {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto, valorBase;

            if (salario <= 2000.00) {
                imposto = 0;
            }
            else if (salario <= 3000.00) {
                valorBase = salario - 2000.00;
                imposto = valorBase * 8 / 100;
            }
            else if (salario <= 4500.00) {
                valorBase = 3000.00 - 2000.00;
                imposto = valorBase * 8 / 100;
                valorBase = salario - 3000.00;
                imposto += valorBase * 18 / 100;
            }
            else {
                valorBase = 3000.00 - 2000.00;
                imposto = valorBase * 8 / 100;
                valorBase = 4500.00 - 3000.00;
                imposto += valorBase * 18 / 100;
                valorBase = salario - 4500.00;
                imposto += valorBase * 28 / 100;
            }

            if (imposto == 0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
