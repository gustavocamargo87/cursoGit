using System;

namespace Exercicio01{
    class Program {
        static void Main(string[] args) {
            int n1;

            n1 = int.Parse(Console.ReadLine());
            if (n1 >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
