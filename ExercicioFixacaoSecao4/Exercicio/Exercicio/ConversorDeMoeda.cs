using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    class ConversorDeMoeda {

        private static double Iof = 6.0;

        public static double DolarParaReal(double valor, double cotacao) {
            double result = valor * cotacao;
            return result += result * Iof / 100;
        }
    }
}
