using System;
using System.Globalization;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A área do círcilo é:" + area.ToString("F4"));
        }
    }
}
