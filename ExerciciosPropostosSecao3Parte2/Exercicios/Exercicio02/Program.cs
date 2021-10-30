using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
