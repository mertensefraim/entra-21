using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var somaValores = 0.0;
            var somaAnos = 0.0;
            var mediaValores = 0.0;
            var mediaAnos = 0.0;
            var valorCarro = 0.0;
            var quantidadeG = 0;
            var quantidadeA = 0;
            var anoCarro = 0;
            var quantidadeVezes = 0;
            var modeloCarro = "";
            var verificador = false;

            while (verificador == false)
            {
                try
                {
                    Console.Write("Digite a quantidade de carros que quer cadastrar: ");
                    quantidadeVezes = Convert.ToInt32(Console.ReadLine());
                    if (quantidadeVezes <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor deve ser maior que 0");
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
                    Console.WriteLine("O valor deve ser número inteiro");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            for (var i = 0; i < quantidadeVezes; i++)
            {
                verificador = false;

                while (verificador == false)
                {
                    Console.Write("Modelo do carro: ");
                    modeloCarro = Console.ReadLine().Trim().ToLower();

                    if (modeloCarro.Length <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome do carro não ser menor que três caracteres");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (modeloCarro.Length >= 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome do carro não ser maior que quinze caracteres");
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
                        Console.Write("Valor do carro: ");
                        valorCarro = Convert.ToDouble(Console.ReadLine());
                        if (valorCarro <= 0)
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
                        Console.WriteLine("O valor digitado não é um número");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Ano do carro: ");
                        anoCarro = Convert.ToInt32(Console.ReadLine());
                        if (anoCarro < 0)
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
                        Console.WriteLine("O valor digitado não é um número inteiro");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if (modeloCarro.StartsWith("a"))
                {
                    quantidadeA++;
                }
                else if (modeloCarro.StartsWith("g"))
                {
                    quantidadeG++;
                }

                somaValores += valorCarro;
                somaAnos += anoCarro;
            }
            mediaAnos = somaAnos / quantidadeVezes;
            mediaValores = somaValores / quantidadeVezes;

            Console.WriteLine("Média anos do carro: " + mediaAnos +
                "\nMédia valores do carro: " + mediaValores +
                "\nQuantidade de carros que começam com a letra G: " + quantidadeG +
                "\nQuantidade de carros que começam com a letra A: " + quantidadeA);
        }
    }
}
