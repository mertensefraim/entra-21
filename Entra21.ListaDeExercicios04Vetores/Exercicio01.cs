using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[16];

            for (var i = 0; i < numeros.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número inteiro: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        verificador = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Esse valor não é um número inteiro, tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            var soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine($"A soma de todos os números é {soma}");
        }
    }
}
