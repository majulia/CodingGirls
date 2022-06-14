using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "N";
            do
            {
                Console.WriteLine("Escolha um exercício:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        VetorCinco();
                        Console.WriteLine("\nContinuar? (S/N)");
                        continuar = Console.ReadLine();

                        break;
                    case 2:
                        ParesEImpares();
                        Console.WriteLine("\nContinuar? (S/N)");
                        continuar = Console.ReadLine();

                        break;
                    case 3:
                        MaiorPalavra();
                        Console.WriteLine("\nContinuar? (S/N)");
                        continuar = Console.ReadLine();

                        break;
                    case 4:
                        Jokenpo();
                        Console.WriteLine("\nContinuar? (S/N)");
                        continuar = Console.ReadLine();

                        break;
                    case 5:
                        JogoDaVelha();
                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Valor inválido. Exercícios de 1 ao 5.");
                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        break;
                }

            } while (continuar != "N");
        }

        static void VetorCinco()
        {

            int[] valor = new int[10];
            int[] novoVetor = new int[10];

            Console.WriteLine("Entre 10 números:");
            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = Convert.ToInt32(Console.ReadLine());
                if (i <= 4)
                {
                    novoVetor[i] = valor[i] * 5;
                }
                else
                {
                    novoVetor[i] = valor[i];
                }

            }

            Console.Write("Vetor original:");
            for (int i = 0; i < valor.Length; i++)
            {
                Console.Write(" " + valor[i]);

            }
            Console.Write("\n");
            Console.Write("Vetor novo:");
            for (int i = 0; i < valor.Length; i++)
            {
                Console.Write(" " + novoVetor[i]);
            }

        }

        static void ParesEImpares()
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            Console.WriteLine($"Digite 10 numeros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }

            Array.Sort(pares);
            Array.Sort(impares);


            Console.WriteLine("\nPares: ");
            foreach (int num in pares)
            {   if(num != 0)
                Console.Write(num + " ");
            }

            Console.WriteLine("\nImpares:");
            foreach (int num in impares)
            {                
                    if (num != 0)
                    Console.Write(num + " ");
            }

        }

        static void MaiorPalavra()
        {
            string[] palavras = new string[5];

            Console.WriteLine("Entre com 5 palavras:");


            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = Console.ReadLine();
            }

            IEnumerable<string> vetorNovo = from palavra in palavras
                                            orderby palavra.Substring(0, 1) descending
                                            select palavra;

            Console.WriteLine("Vetor ordenado:");
            foreach (string str in vetorNovo)
                Console.WriteLine(str);

            Console.ReadLine();
        }

        static void Jokenpo()
        {
            int rodadas;
            int placarJog = 0;
            int placarComp = 0;
            string[] computador = { "Pedra", "Papel", "Tesoura" };
            Random rnd = new Random();
            int index = rnd.Next(computador.Length);
           
            Console.WriteLine("Deseja jogar quantas rodadas?");
            rodadas = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < rodadas; i++)
            {
                Console.WriteLine($"\n Rodada {i + 1}");
                Console.WriteLine("Escolha (Pedra, Papel ou Tesoura):");
                string jogador1 = Console.ReadLine();

                Console.WriteLine($"Escolha do computador:\n {computador[index]}");


                if ((jogador1 == "Pedra" && computador[index] == "Tesoura") || (jogador1 == "Tesoura" && computador[index] == "Papel")
                    || (jogador1 == "Papel" && computador[index] == "Pedra"))
                {
                    placarJog += 1;
                }
                else if (computador[index] == "Pedra" && jogador1 == "Tesoura" || computador[index] == "Tesoura" && jogador1 == "Papel"
                    || computador[index] == "Papel" && jogador1 == "Pedra")
                {
                    placarComp += 1;
                }


            }

            if (placarComp > placarJog)
            {
                Console.WriteLine("Computador Ganhou, Pontos: " + placarComp);
            }
            else if (placarComp < placarJog)
            {
                Console.WriteLine("Jogador Ganhou, Pontos: " + placarJog);

            }
            else
            {
                Console.WriteLine("Empate");
            }

        }

        static void JogoDaVelha()
        {
            string resposta;
            do
            {
                string[,] jogo = new string[3, 3];

                int count = 0;
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        count++;
                        jogo[l, c] = Convert.ToString(count);
                    }
                }
                Console.WriteLine("---------------------JOGO DA VELHA--------------------");
                Console.WriteLine();
                Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");
                int i;
                string jogada, teste;
                while (count > 0)
                {
                    Console.WriteLine("Entre com a posição que você deseja jogar");
                    i = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Entre com X ou O:");
                    jogada = Console.ReadLine();

                    teste = (i == 1) ? jogo[0, 0] = jogada : (i == 2) ? jogo[0, 1] = jogada : (i == 3) ? jogo[0, 2] = jogada :
                        (i == 4) ? jogo[1, 0] = jogada : (i == 5) ? jogo[1, 1] = jogada : (i == 6) ? jogo[1, 2] = jogada :
                        (i == 7) ? jogo[2, 0] = jogada : (i == 8) ? jogo[2, 1] = jogada : jogo[2, 2] = jogada;

                    Console.WriteLine();
                    Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");

                    if ((jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[1, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X"))
                    {
                        Console.WriteLine("O Jogador X ganhou!");
                        break;

                    }
                    else if ((jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "O" && jogo[2, 1] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[1, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[2, 0] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[1, 0] == "O" && jogo[1, 1] == "O" && jogo[1, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O"))
                    {
                        Console.WriteLine("O Jogador O ganhou!");
                        break;
                    }
                    else if (count == 1)
                    {
                        Console.WriteLine("Deu Velha!");
                    }
                    count++;
                }

                Console.WriteLine("Quer jogar novamente?(S/N)");
                resposta = Console.ReadLine();

            } while (resposta == "S");
        }

    }
}
