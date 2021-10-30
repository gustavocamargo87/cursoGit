using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {            
            string[] vet; int x; int y; string q;

            do {

                Console.WriteLine("Digite as coordenadas :");

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                q = Quadrante(x, y);

                Console.WriteLine(q);
            }
            while (q != "");
        }

        static string Quadrante(int x, int y) {
            if (x == 0 || y == 0) {
                return "";
            }
            else if (x > 0 && y > 0) {
                return "Primeiro";
            }
            else if (x > 0 && y < 0) {
                return "Quarto";
            }
            else if (x < 0 && y > 0) {
                return "Segundo";
            }
            else {
                return "Terceiro";
            }
        }
    }
}
