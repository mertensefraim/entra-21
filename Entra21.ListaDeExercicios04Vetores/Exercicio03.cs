using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomes = new string[3];
            double[] valores = new double[3];

            var texto = "";

            for (var i = 0; i < nomes.Length; i++)
            {
                var verificador = false;

                while (verificador == false)
                {
                    Console.Write($"Nome do {i + 1}° produto: ");
                    nomes[i] = Console.ReadLine();
                    if (nomes[i].Length <= 2 || nomes[i].Length >= 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome do produto deve ser de no minímo 2 caracteres e no máximo 15");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        verificador = true;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Valor {nomes[i]}: ");
                        valores[i] = Convert.ToDouble(Console.ReadLine());
                        if (valores[i] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor não pode ser nulo");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (valores[i] < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor não pode ser negativo");
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
                        Console.WriteLine("Esse valor não é um número");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                texto = texto + "\n" + nomes[i] + "         " + valores[i];
            }
            Console.WriteLine("Nomes         Valores");
            Console.WriteLine(texto);
        }
    }
}
