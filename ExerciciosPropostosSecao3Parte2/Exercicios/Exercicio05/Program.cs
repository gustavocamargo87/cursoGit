using System;
using System.Globalization;

namespace Exercicio05 {
    class Program {
        static void Main(string[] args) {
            /*
             * CODIGO ESPECIFICACAO     PREÇO
             * 1      Cachorro Quente   R$ 4.00
             * 2      X-Salada          R$ 4.50
             * 3      X-Bacon           R$ 5.00
             * 4      Torrada Simples   R$ 2.00
             * 5      Refrigerante      R$ 1.50  
             */

            string[] vet;
            int codigo, qtd;
            double valor;

            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            
            if (codigo == 1) {
                valor =  qtd * 4.00;
            }
            else if (codigo == 2) {
                valor = qtd * 4.50;
            }
            else if (codigo == 3) {
                valor = qtd * 5.00;
            }
            else if (codigo == 4) {
                valor = qtd * 2.00;
            }
            else {
                valor = qtd * 1.50;
            }            
            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
