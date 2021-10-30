using System;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            int numero;
            string titular;
            char comDepositoInicial;
            double deposito, saque;

            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();

            Conta c;

            Console.Write("Haverá depósito inicial (s/n)? ");
            comDepositoInicial = char.Parse(Console.ReadLine());

            if (comDepositoInicial == 's') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, titular, depositoInicial);
            }
            else {
                c = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

        }

    }
}
