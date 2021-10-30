using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o Número 1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Número 2:");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
