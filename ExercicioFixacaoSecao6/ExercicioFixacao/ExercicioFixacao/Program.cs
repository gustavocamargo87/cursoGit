using System;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quarto[] quartos = new Quarto[10];
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                quartos[numero] = new Quarto(numero, nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i=0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(quartos[i]);
                }                
            }



        }
    }
}
