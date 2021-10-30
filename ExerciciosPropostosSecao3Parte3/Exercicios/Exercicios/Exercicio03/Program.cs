using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            int n1, qtdGas, qtdAlc, qtdDie;

            qtdAlc = 0;
            qtdGas = 0;
            qtdDie = 0;

            n1 = int.Parse(Console.ReadLine());
            while (n1 != 4) {
                if (n1 == 1) {
                    qtdAlc += 1;
                }
                else if (n1 == 2) {
                    qtdGas += 1;
                }
                else if (n1 == 3){
                    qtdDie += 1;
                }
                n1 = int.Parse(Console.ReadLine());
            }
        
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + qtdAlc);
            Console.WriteLine("Gasolinha: " + qtdGas);
            Console.WriteLine("Diesel: " + qtdDie);
        }
    }
}
