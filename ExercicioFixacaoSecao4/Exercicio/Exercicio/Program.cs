using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorReais = ConversorDeMoeda.DolarParaReal(valor, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + valorReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
