using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao {
    class Quarto {
        public int Numero { get; set; }
        public string NomeLocatario { get; set; }
        public string EmailLocatario { get; set; }

        public Quarto(int numero, string nome, string email) {
            Numero = numero;
            NomeLocatario = nome;
            EmailLocatario = email;
        }

        public override string ToString() {
            return Numero 
                + ": "
                + NomeLocatario 
                + ", " 
                + EmailLocatario;
        }
    }
}
