using System;
using System.Globalization;

namespace Exercicio06 {
    class Program {
        static void Main(string[] args) {
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            double a, b, c, pi;
            string[] vetor;

            pi = 3.14159;
            vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            areaTriangulo = a * c / 2;
            areaCirculo = pi * Math.Pow(c, 2);
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
