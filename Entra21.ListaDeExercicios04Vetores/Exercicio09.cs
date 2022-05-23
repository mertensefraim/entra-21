using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio09
    {
        public void Executar()
        {
            string[] nomes = new string[5];
            string[] nomesInverso = new string[5];
            var textoNomes = "";
            var textoNomesInverso = "";

            for (var i = 0; i < nomes.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    Console.Write($"Digite o {i + 1}º nome: ");
                    nomes[i] = Console.ReadLine();
                    if (nomes[i].Length <= 3 || nomes[i].Length >= 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de caracteres do nome deve ser maio que 3 e menor que 15!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        verificador = true;
                    }
                }
            }

            for (var i = 4; i >= 0; i--)
            {
                nomesInverso[i] = nomes[(nomesInverso.Length - 1) - i];
                textoNomes = textoNomes + nomes[i] + ", ";
                textoNomesInverso = textoNomesInverso + nomesInverso[i] + ", ";
            }

            Console.WriteLine($"Nomes: {textoNomes} " +
                $"\nNomesInverso: {textoNomesInverso}");
        }   
    }
}
