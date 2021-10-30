using System;
using System.Globalization;

namespace ExercicioFixacao {
    class Conta {                

        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public Conta() {
            Saldo = 0.00;
        }

        public Conta(int numero, string titular): this() {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial): this(numero, titular) {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            double TaxaSaque = 5.00;
            Saldo -= valor + TaxaSaque;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        
        
    }
}
