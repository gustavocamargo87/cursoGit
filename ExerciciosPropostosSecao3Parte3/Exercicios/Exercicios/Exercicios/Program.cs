using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a senha:");
            string senha;

            senha = Console.ReadLine();

            while (!SenhaValida(senha)) {
                Console.WriteLine("Senha Inválida!");
                Console.Write("Digite a senha:");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido!");
        }

        static bool SenhaValida(string senha) {
            return senha == "2002";
        }                        
    }
}
