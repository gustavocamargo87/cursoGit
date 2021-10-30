﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03 {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            return NotaFinal() >= 60;
        }

        public double PontosParaAprovacao() {
            return 60 - NotaFinal();
        }

    }
}
