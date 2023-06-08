using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09PR2
{
    internal class Program
    {


        public static void Ex1()
        {
            float mediaA = 0;
            int[] vet2;
            Console.WriteLine("Escreva o tamanho do vetor:");
            int p = int.Parse(Console.ReadLine());

            vet2 = new int[p];
            Random rand = new Random();
            for (int i = 0; i < p; i++)
            {
                vet2[i] = rand.Next(10, 50);
            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("Posição [{0}] = {1}", i, vet2[i]);
                mediaA = vet2[i] + mediaA;
            }
            mediaA = mediaA / (float)p;

            Console.WriteLine("A média aritimética é " + mediaA);

            Console.ReadKey();
        }

        public static void Ex2()
        {
            int[] vet2;
            Console.WriteLine("Escreva o tamanho do vetor:");
            int j = int.Parse(Console.ReadLine());

            vet2 = new int[j];
            Random rand = new Random();

            for (int i = 0; i < j; i++)
            {
                vet2[i] = rand.Next(10, 50);
            }
            int somaP = 0;
            int somaI = 0;
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Esta é a posição [{0}] = {1}", i, vet2[i]);
                if (vet2[i] % 2 == 0)
                {
                    somaP += vet2[i];
                }
                else
                {
                    somaI += vet2[i];
                }
            }
            Console.WriteLine("A soma dos pares é: " + somaP);
            Console.WriteLine("A soma dos impares é: " + somaI);
            Console.ReadKey();

        }

        public static void Ex3()
        {
            int[] vetor2;
            Console.WriteLine("Digite o tamanho do vetor:");
            int u = int.Parse(Console.ReadLine());

            vetor2 = new int[u];
            Random aleatorio = new Random();

            for (int i = 0; i < u; i++)
            {
                vetor2[i] = aleatorio.Next(10, 50);
            }

            for (int i = 0; i < u; i++)
            {
                Console.WriteLine("Posição [{0}] = {1}", i, vetor2[i]);

            }

            Console.WriteLine();
            for (int i = u - 1; i >= 0; i--)
            {
                Console.WriteLine("Posição [{0}] = {1}", i, vetor2[i]);
            }

        }

        public static void Ex4()
        {
            float media = 0;
            int[] vetor2;
            Console.WriteLine("Digite o tamanho do vetor:");
            int v = int.Parse(Console.ReadLine());

            vetor2 = new int[v];
            Random rand = new Random();

            for (int i = 0; i < v; i++)
            {
                vetor2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vetor2[i]);
                if (vetor2[i] % 3 == 0 && vetor2[i] % 5 == 0)
                {
                    media = vetor2[i] + media;
                }


            }

            media = media / (float)v;
            Console.WriteLine("a media aridimentica é" + media);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int opção;

            do
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("Digite um exercicio");
                Console.WriteLine("(Digite um número de 1 à 4 ou 0 para sair do programa:)");

                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar meu programa!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;

                    case 4:
                        Ex4();
                        break;
                }
            }
            while (opção != 0);

        }
    }
}
