using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int qtdIn, qtdOut;

            qtdIn = 0;
            qtdOut = 0; 
            for (int i = 1; i <= n; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) {
                    qtdIn += 1;
                }
                else {
                    qtdOut += 1;  
                }
            }
            Console.WriteLine("{0} in", qtdIn);
            Console.WriteLine("{0} out", qtdOut);
        }
    }
}
