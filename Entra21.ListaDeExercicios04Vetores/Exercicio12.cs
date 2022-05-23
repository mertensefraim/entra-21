using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio12
    {
        public void Executar()
        {
            int[] numeros = new int[5];
            int[] numerosCrescente = new int[5];
            var textoNumeros = "";
            var textoNumerosCrescente = "";

            for (var i = 0; i < numeros.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        verificador = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("o número deve ser um inteiro!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            var contador = 1;
            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < numeros[contador])
                {
                    numerosCrescente[i] = numeros[i];
                    textoNumerosCrescente = textoNumerosCrescente + numerosCrescente[i] + "|";
                }
                else
                {
                    numeros[i] = numeros[contador];
                    numerosCrescente[i] = numeros[contador];
                    textoNumerosCrescente = textoNumerosCrescente + numerosCrescente[i] + "|";
                }
                if (contador != numeros.Length - 1)
                {
                    contador++;
                }
                textoNumeros = textoNumeros + numeros[i] + "|";
            }

            Console.WriteLine($"Números: {textoNumeros}" +
                $"\nNúmeros Crescentes: {textoNumerosCrescente}");
        }
    }
}
