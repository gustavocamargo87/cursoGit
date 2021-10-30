using System;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            string[] dimensoes = Console.ReadLine().Split(' ');
            int l = int.Parse(dimensoes[0]);
            int c = int.Parse(dimensoes[1]);
            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j= 0; j < c; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (mat[i, j] == n) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j-1]);
                        }
                        if (j < c-1) {
                            Console.WriteLine("Rigth: " + mat[i, j+1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i-1, j]); 
                        }
                        if (i < l-1) {
                            Console.WriteLine("Down: " + mat[i+1, j]);
                        }                        
                    }
                }
            }

        }

    }
}
