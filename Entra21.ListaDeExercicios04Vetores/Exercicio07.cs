using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio07
    {
        public void Executar()
        {
            double[] alturas = new double[4];
            var menorAltura = double.MaxValue;

            for (var i = 0; i < alturas.Length; i++)
            {
                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write($"Digite a altura do {i + 1}° animal: ");
                        alturas[i] = Convert.ToDouble(Console.ReadLine());
                        if (alturas[i] < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A altura não pode ser negativa!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (alturas[i] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A altura não pode ser nula!!!");
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
                        Console.WriteLine("A idade deve ser um número!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            for (var i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }

            Console.WriteLine($"A menor altura dos animais foi {menorAltura} metros");
        }
    }
}
