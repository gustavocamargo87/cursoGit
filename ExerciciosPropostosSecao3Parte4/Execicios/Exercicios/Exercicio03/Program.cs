using System;
using System.Globalization;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];
            for (int i = 0; i <= n - 1; i++) {
                vet[i] = Console.ReadLine();
            }
            for (int z = 0; z <= vet.Length - 1; z++) {
                string[] valores = vet[z].Split(' ');
                double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double media = MediaPonderada(n1, n2, n3);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }


        static double MediaPonderada(double a, double b, double c) {
                return ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);
        }
    }
}
