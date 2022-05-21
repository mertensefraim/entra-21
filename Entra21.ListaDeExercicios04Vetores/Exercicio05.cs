using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];

            var soma = 0.0;
            var media = 0.0;

            for (var i = 0; i < pesos.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° peso: ");
                        pesos[i] = Convert.ToDouble(Console.ReadLine());
                        if (pesos[i] < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor do peso não pode ser negativo");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (pesos[i] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor do peso não pode ser nulo");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O valor deve ser um número.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            for (var i = 0; i < pesos.Length; i++)
            {
                soma = soma + pesos[i];
            }

            media = soma / pesos.Length;

            Console.WriteLine($"A média é {media} e a soma é {soma}");
        }
       
    }
}
