using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio06
    {
        public void Executar()
        {
            int[] idades = new int[4];
            var menorIdade = int.MaxValue;

            for (var i = 0; i < idades.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite a idade da {i + 1}° pessoa: ");
                        idades[i] = Convert.ToInt32(Console.ReadLine());
                        if (idades[i] < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A idade não pode ser negativa!!!");
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
                        Console.WriteLine("A idade deve ser um inteiro!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            for (var i = 0; i < idades.Length; i++)
            {
                if (idades[i] < menorIdade)
                { 
                    menorIdade = idades[i];
                }
            }

            Console.WriteLine($"A menor idade é {menorIdade}");
        }
    }
}
