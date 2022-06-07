using System;
namespace ExeAula01
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "N";

            do {

                Console.WriteLine("Exercícios Aula 01 - Coding Girls");
                Console.WriteLine("Escolha um exercício:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 - Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.");
                        Console.WriteLine("Maria Julia de Oliveira");
                        Console.WriteLine("Rua dos Alfeneiros, 4");
                        Console.WriteLine("00000-000");
                        Console.WriteLine("(12)3133-3333");

                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        
                        break;

                    case 2:

                        Console.WriteLine("2 - Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.");

                        Console.WriteLine("Grace Hopper");
                        Console.WriteLine("Graduou-se em 1928 como bacharel em Matemática e Física e, em 1930, concluiu seu mestrado na Yale University. Em 1934, também na Yale University, conquistou seu Ph.D. em Matemática.");
                        Console.WriteLine("Hopper foi uma analista de sistemas da Marinha dos Estados Unidos nas décadas de 1940 e 1950, e enquanto atuava por lá desenvolveu a linguagem de programação Flow-Matic, que foi a primeira delas a ser adaptada para o idioma inglês. Essa linguagem, apesar de já extinta, serviu como base para a criação do COBOL (Common Business Oriented Language) – usado até os dias de hoje em processamento de bancos de dados comerciais.");

                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();

                        break;

                    case 3:
                        Console.WriteLine("3 - Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.");
                        
                        Console.WriteLine("Million Years Ago");
                        Console.WriteLine("Composição: Adele, Greg Kurstin");
                        Console.WriteLine("\nI only wanted to have fun");
                        Console.WriteLine("Learning to fly, learning to run" +
                            "\nI let my heart decide the way" +
                            "\nWhen I was young" +
                            "\nDeep down I must have always known" +
                            "\nThat this would be inevitable" +
                            "\nTo earn my stripes I'd have to pay" +
                            "\nAnd bear my soul" +
                            "\n" +
                            "\nI know I'm not the only one" +
                            "\nWho regrets the things they've done" +
                            "\nSometimes I just feel it's only me" +
                            "\nWho can't stand the reflection that they see" +
                            "\nI wish I could live a little more" +
                            "\nLook up to the sky, not just the floor" +
                            "\nI feel like my life is flashing by" +
                            "\nAnd all I can do is watch and cry" +
                            "\nI miss the air, I miss my friends" +
                            "\nI miss my mother; I miss it when" +
                            "\nLife was a party to be thrown" +
                            "\nBut that was a million years ago" +
                            "\n" +
                            "\nWhen I walk around all of the streets" +
                            "\nWhere I grew up and found my feet" +
                            "\nThey can't look me in the eye" +
                            "\nIt's like they're scared of me" +
                            "\nI try to think of things to say" +
                            "\nLike a joke or a memory" +
                            "\nBut they don't recognize me now" +
                            "\nIn the light of day" +
                            "\n" +
                            "\nI know I'm not the only one" +
                            "\nWho regrets the things they've done" +
                            "\nSometimes I just feel it's only me" +
                            "\nWho can't stand the reflection that they see" +
                            "\nI wish I could live a little more" +
                            "\nLook up to the sky, not just the floor" +
                            "\nI feel like my life is flashing by" +
                            "\nAnd all I can do is watch and cry" +
                            "\nI miss the air, I miss my friends" +
                            "\nI miss my mother; I miss it when" +
                            "\nLife was a party to be thrown" +
                            "\nBut that was a million years ago" +
                            "\n");

                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        break;

                    case 4:

                        Console.WriteLine("4 - Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.");

                        Console.WriteLine(" 'Os profissionais que seguem carreira na tecnologia influenciam o conhecimento e o descobrimento da história tecnológica. Mesmo que já existam diversas descobertas, é um campo muito recente, e as chances de progresso são cada vez maiores. Imagine a sensação de que você fez parte disso?' - SOS Educação");
                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Valor inválido. Exercícios de 1 ao 4.");
                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        break;
                }

            } while (continuar != "N");
        }
    }
}
