using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int[] numeros = new int[10];
            string textoNumeros = "";
            string textoNumerosPares = "";
            string textoNumerosImpares = "";
            int quantidadePares = 0;
            int quantidadeImpares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        if (numeros[i] % 2 == 0)
                        {
                            quantidadePares = quantidadePares + 1;
                        }
                        else if (numeros[i] % 2 != 0)
                        {
                            quantidadeImpares = quantidadeImpares + 1;
                        }
                        verificador = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("o número deve ser um inteiro!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                textoNumeros = textoNumeros + numeros[i] + "|";
            }
            
            for (var i = 0; i < numeros.Length; i++)
            {
                int[] numerosPares = new int[quantidadePares];
                if (numeros[i] % 2 == 0 )
                {
                    numerosPares[i] = numeros[i];
                    if (i <= quantidadePares)
                    {
                        textoNumerosPares = textoNumerosPares + numerosPares[i] + "|";
                    }
                    else
                    {
                        textoNumerosPares = textoNumerosPares + numerosPares[i ] + "|";
                    }
                }
            }

            for (var i = 0; i < numeros.Length; i++)
            {
                int[] numerosImpares = new int[quantidadeImpares];
                if (numeros[i] % 2 != 0 && i <= quantidadeImpares)
                {
                    numerosImpares[i] = numeros[i];
                    textoNumerosImpares = textoNumerosImpares + numerosImpares[i] + "|";
                }
            }

            Console.WriteLine($"Números: {textoNumeros}" +
                $"\nNúmeros pares: {textoNumerosPares}" +
                $"\nNúmeros impares: {textoNumerosImpares}");
        }
    }
}
