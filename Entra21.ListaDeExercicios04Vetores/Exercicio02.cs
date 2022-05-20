using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[3];

            for (var i = 0; i < nomes.Length; i++)
            {
                var verificador = false;
                
                while (verificador == false)
                {
                    Console.Write($"Digite o {i + 1}° nome: ");
                    nomes[i] = Console.ReadLine().Trim();

                    if (nomes[i].Length <= 2 || nomes[i].Length >= 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de caracteres do nome deve ser maior que 2 e menor que 15. Tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        verificador = true;
                    }
                }
            }

            var nomesTexto = "";

            for (var i = 0; i < nomes.Length; i++)
            {
                //if (i == 0)
                //{
                //    nomesTexto = nomes[i];
                //}
                //else if (i < nomes.Length - 1)
                //{
                //    nomesTexto = nomesTexto + ", " + nomes[i];
                //}
                //else
                //{
                //    nomesTexto = nomesTexto + " e " + nomes[i];
                //}
                if (i < nomes.Length - 2)
                {
                    nomesTexto = nomesTexto + nomes[i] + ", ";
                }
                else if (i == nomes.Length - 2)
                {
                    nomesTexto = nomesTexto + nomes[i];
                }
                else
                {
                    nomesTexto = nomesTexto + " e " + nomes[i];
                }
                
            }
            Console.WriteLine($"Nomes: {nomesTexto}");
        }
    }
}
