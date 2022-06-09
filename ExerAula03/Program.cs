using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notas();
            //MaiorValor();
            //MediaAluno();
            //AprovadoReprovado();
            //AumentoSalario();
        }

        //Exercicio 01 
        //Leia um valor de ponto flutuante com duas casas decimais.
        //Este valor representa um valor monetário.A seguir, calcule o menor número de notas
        // e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2.
        static void Notas()
        {
            int notaCem = 0;
            int notaCinq = 0;
            int notaVinte = 0;
            int notaDez = 0;
            int notaCinco = 0;
            int notaDois = 0;

            Console.WriteLine("Entre com o valor monetário: ");
            double total = Convert.ToDouble(Console.ReadLine());


            while (total >= 100.00)
            {
                total = total - 100.00;
                notaCem += 1;
            }
            while (total >= 50.00)
            {
                total = total - 50.00;
                notaCinq += 1;
            }
            while (total >= 20.00)
            {
                total = total - 20.00;
                notaVinte += 1;
            }
            while (total >= 10.00)
            {
                total = total - 10.00;
                notaDez += 1;
            }
            while (total >= 5.00)
            {
                total = total - 5.00;
                notaCinco += 1;
            }
            while (total >= 2.00)
            {
                total = total - 2.00;
                notaDois += 1;
            }


            Console.WriteLine($"Quantidade nota de R$ 100: {notaCem}");
            Console.WriteLine($"Quantidade nota de 50: {notaCinq}");
            Console.WriteLine($"Quantidade nota de 20: {notaVinte}");
            Console.WriteLine($"Quantidade nota de 10: {notaDez}");
            Console.WriteLine($"Quantidade nota de 5: {notaCinco}");
            Console.WriteLine($"Quantidade nota de 2: {notaDois}");
            Console.ReadLine();
        }

        //2. Faça um programa que leia três valores e apresente o 
        //maior dos três valores lidos seguido da mensagem “x é o maior”.
        //Exercicio 2
        static void MaiorValor()
        {
            Console.WriteLine("Valor 1:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 3:");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine($"O maior é: {valor1}");
            }
            else if (valor2 > 1 && valor2 > valor3)
            {
                Console.WriteLine($"O maior é: {valor2}");
            }
            else
            {
                Console.WriteLine($"O maior é: {valor3}");
            }
            Console.ReadLine();
        }

        //3.Leia 3 valores que são as três notas de um aluno.A seguir, calcule a média do aluno.
        //Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. 
        //Imprima se o aluno foi aprovado ou reprovado considerando a média 7.

        static void MediaAluno()
        {
            Console.WriteLine("Entre com a nota 1:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com a nota 2:");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com a nota 3:");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 0 && media <= 6)
            {
                Console.WriteLine($"A média foi {media.ToString("F")}. Aluno Reprovado");
            }
            else if (media >= 7 && media <= 10)
            {
                Console.WriteLine($"A média foi {media.ToString("F")}. Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

            Console.ReadLine();

        }

        //4.Leia 3 valores que são as três notas de um aluno.A seguir, calcule a média do aluno.
        //Exercicio 4
        static void AprovadoReprovado()
        {
            Console.WriteLine("Nota 1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 3:");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            double media = (valor1 + valor2 + valor3) / 3;

            if (media < 6.0)
            {
                Console.WriteLine($"O Aluno tirou F! Reprovado");
            }
            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou D! Reprovado");
            }
            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou C! Parabéns");
            }
            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou B. Parabéns!");
            }
            else if (media >= 9.0 && media <= 10)
            {
                Console.WriteLine($"{media}, O Aluno tirou A. Parabéns!");
            }
            Console.ReadLine();


        }

        //5. A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
        //Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 
        //ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
        //Exercicio 5
        static void AumentoSalario()
        {
            double salarioNovo;
            double ganho;

            Console.WriteLine("Entre com o seu salário:");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());


            if (salarioAtual == 0 || salarioAtual <= 400.00)
            {
                salarioNovo = salarioAtual + (0.15 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho} - Em percentual: 15%");
            }
            else if (salarioAtual == 400.01 || salarioAtual <= 800.00)
            {
                salarioNovo = salarioAtual + (0.12 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho} - Em percentual: 12%");
            }
            else if (salarioAtual == 800.01 && salarioAtual <= 1200.00)
            {
                salarioNovo = salarioAtual + (0.10 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 10%");
            }
            else if (salarioAtual == 1200.01 || salarioAtual <= 2000.00)
            {
                salarioNovo = salarioAtual + (0.07 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 7%");
            }
            else
            {
                salarioNovo = salarioAtual + (0.04 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 4%");
            }

            Console.ReadLine();
        }

    }
}
