using System;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            string[] vet;
            int horaIni, horaFim, duracao;

            vet = Console.ReadLine().Split(' ');
            horaIni = int.Parse(vet[0]);
            horaFim = int.Parse(vet[1]);
            if (horaFim <= horaIni) {
                duracao = 24 - horaIni + horaFim;
            }
            else {
                duracao = horaFim - horaIni;
            }            
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);

        }
    }
}
