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
            var modeloCarro = "";

            Console.Write("Digite a quantidade de carros que quer cadastrar: ");
            var quantidadeVezes = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i == quantidadeVezes; i++)
            {
                var verificador = false;

                while (verificador == false)
                {
                    Console.Write("Modelo do carro: ");
                    modeloCarro = Console.ReadLine();

                    if (modeloCarro.Length <= 3)
                    {
                        Console.WriteLine("O nome da peça não ser menor que dois caracteres");
                    }
                    else if (modeloCarro.Length >= 15)
                    {
                        Console.WriteLine("O nome da peça não ser maior que quinze caracteres");
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
                        verificador = true;
                        if (valorCarro < 0)
                        {
                            Console.WriteLine("O valor não pode ser negativo");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O valor digitado não é um número");
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Ano do carro: ");
                        anoCarro = Convert.ToInt32(Console.ReadLine());
                        verificador = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O valor digitado não é um número inteiro");
                    }
                }

                if (modeloCarro.StartsWith("a"))
                {
                    quantidadeA = quantidadeA + 1;
                }
                else if (modeloCarro.StartsWith("g"))
                {
                    quantidadeG = quantidadeG + 1;
                }

                somaValores = somaValores + valorCarro;
                somaAnos = somaAnos + valorCarro;
            }
            mediaAnos = somaAnos / quantidadeVezes;
            mediaValores = somaAnos / quantidadeVezes;

            Console.WriteLine("Média anos do carro: " + mediaAnos +
                "\nMédia valores do carro: " + mediaValores +
                "\nQuantidade de carros que começam com a letra G: " + quantidadeG +
                "\nQuantidade de carros que começam com a letra A: " + quantidadeA);
        }
    }
}
