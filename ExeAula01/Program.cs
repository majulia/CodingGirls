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
                        
                        Console.WriteLine(@"
The sky is a neighborhood - Foo Fighters");
                        Console.WriteLine("Composição: Christopher Shiflett / David Eric Grohl / Nathan Mendel / Oliver Hawkins / Pat Smear / Rami Jaffee");
                        Console.WriteLine(@"The sky is a neighborhood
So keep it down
The heart is a storybook
A star burned out
The sky is a neighborhood
Don't make a sound
Lights coming up ahead
Don't look now

The sky is a neighborhood
The sky is a neighborhood
Don't look now

Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down
Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down

Mind is a battlefield
All hope is gone
Trouble to the right and left
Whose side you're on?
Thoughts like a minefield
I'm a ticking bomb
Maybe you should watch your step
Don't get lost

The sky is a neighborhood
The sky is a neighborhood
Don't get lost

Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down
Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down

The sky is a neighborhood

The heart is a storybook
A star burned out
Someone coming up ahead
Don't look now

Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down
Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow
Bangin' on the ceiling, bangin' on the ceiling
Keep it down

The sky is a neighborhood
(Oh, my dear, heaven is a big bang now
Gotta get to sleep somehow)
The sky is a neighborhood
(Bangin' on the ceiling, bangin' on the ceiling
Keep it down)

The sky is a neighborhood");

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
