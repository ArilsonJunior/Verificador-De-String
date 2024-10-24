using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            do
            {
                Console.Write("Escreva uma frase OU texto: ");
                string entrada = Console.ReadLine();

                int contagem = ContarOcorrenciasA(entrada);

                bool existe = contagem > 0;

                if (existe)
                {
                    Console.WriteLine($"\nA letra 'a' (maiúscula ou minúscula) aparece {contagem} vez(es) na string.\n");
                }
                else
                {
                    Console.WriteLine("\nA letra 'a' (maiúscula ou minúscula) não aparece na string.\n");
                }

                Console.WriteLine("Deseja fazer outra consulta?\n" +
                   "[1] - Sim\n" +
                   "[2] - Não");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 2)
                {
                    sair = true;
                }

            } while (!sair);
        }

        static int ContarOcorrenciasA(string str)
        {
            int contagem = 0;

            foreach (char c in str)
            {
                if (c == 'a' || c == 'A')
                {
                    contagem++;
                }
            }
            return contagem;
        }
    }
}
