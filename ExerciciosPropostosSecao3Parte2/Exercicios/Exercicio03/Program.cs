using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            string[] vet;
            int n1, n2;            

            vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não são Multiplos");
            }

        }
    }
}
