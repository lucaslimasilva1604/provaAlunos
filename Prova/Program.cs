using System;
using System.Globalization;

namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] gabarito = new char[5];

            Console.WriteLine("PASSO 1 - Cadastro de Gabarito");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Questão  {i + 1}: ");
                gabarito[i] = char.Parse(Console.ReadLine());
            }

            Console.Clear();

            int[] notas = new int[5];

            string[] nome = new string[3];
            int[] notasDoAluno = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"ALUNO  {i + 1}");
                Console.WriteLine("-------------------------");

                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("RESPOSTAS DADAS");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Questão  {j + 1}: ");
                    notas[j] = char.Parse(Console.ReadLine());
                }

                int notaDeTodos = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (gabarito[j] == notas[j])
                    {
                        notaDeTodos += 2;
                    }
                }

                notasDoAluno[i] = notaDeTodos;
                Console.Clear();
            }

            Console.WriteLine("NOTAS FINAIS");
            Console.WriteLine("----------------------------");

            int soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Format($"{nome[i],-10}{notasDoAluno[i].ToString("F1", CultureInfo.InvariantCulture)}"));
                soma += notasDoAluno[i];
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Media da turma:  {(soma / 3).ToString("F1", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
