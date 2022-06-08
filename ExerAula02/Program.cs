using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula02
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
                        DataNasc();
                        break;
                    case 2:
                        SomaValor();
                        break;
                    case 3:
                        CalculoSalario();
                        break;
                    case 4:
                        Idade();
                        break;
                    case 5:
                        Conversao();
                        break;
                    default:
                        Console.WriteLine("Valor inválido. Exercícios de 1 ao 5.");
                        Console.WriteLine("Continuar? (S/N)");
                        continuar = Console.ReadLine();
                        break;
                }

            } while (continuar != "N");
        }

        static void DataNasc()
        {
            int anoAtual = 2022;
            int idade;

            Console.WriteLine("Insira o ano do seu nascimento: ");
            int anoNasc = Convert.ToInt32(Console.ReadLine());

            idade = anoAtual - anoNasc;
            Console.WriteLine($"Sua idade é {idade}");
            Console.WriteLine("Valor inválido. Exercícios de 1 ao 5.");
        }

        static void SomaValor()
        {
            int i;
            double soma = 0;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Insira 10 números.");
                Console.Write($"Insira o {i}º: ");
                double num = Convert.ToInt32(Console.ReadLine());

                soma += num;
            }

            Console.WriteLine($"O total de soma do elementos: {soma}");
            Console.ReadLine();
        }

        static void CalculoSalario()
        {
            Console.WriteLine("Insira as horas trabalhadas: ");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor da horas: ");
            double valorHoras = Convert.ToDouble(Console.ReadLine());

            double salario = horasTrabalhadas * valorHoras;

            Console.WriteLine($" O salário total é: {salario.ToString("F")} R$");

            Console.ReadLine();

        }

        static void Idade()
        {
            Console.WriteLine("Insira sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            int meses = idade * 12;
            int dias = idade * 365;


            Console.WriteLine($"Anos: {idade} - Meses: {meses} - Dias: {dias}");
            Console.ReadLine();

        }

        static void Conversao()
        {
            double real = 0;

            Console.WriteLine("Conversor de real:");
            real = Convert.ToDouble(Console.ReadLine());

            double dolar = real / 4.87;
            double euro = real / 5.21;
            double libra = real / 6.13;
            double dolarCana = real / 3.89;
            double pesoArg = real / 0.040;
            double pesoChi = real / 0.0059;

            Console.WriteLine($" Real para Dolar : {dolar.ToString("F")}");
            Console.WriteLine($" Real para Euro : {euro.ToString("F")}");
            Console.WriteLine($" Real para Libra : {libra.ToString("F")}");
            Console.WriteLine($" Real para Dolar Canadense : {dolarCana.ToString("F")}");
            Console.WriteLine($" Real para Peso Argentino : {pesoArg.ToString("F")}");
            Console.WriteLine($" Real para Peso Chileno : {pesoChi.ToString("F")}");
            Console.ReadLine();

        }
    }
}
