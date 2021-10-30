using System;

namespace Exercicio05 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());                        
            Console.WriteLine(Fatorial(n));
        }

        static int Fatorial(int n) {
            if (n == 0) {
                return 1;
            }
            else {
                int resultado = n;

                for (int i = n - 1; i >= 1; i--) {
                    resultado *= i;
                }
                return resultado;
            }
        }
    }
}
