using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio01
    {
        public void Executar()
        {
            var precoPeca = 0.0;
            var nomePeca = "";
            var texto = "";
            for (var i = 0; i < 5; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Digite preço da peça: ");
                        precoPeca = Convert.ToDouble(Console.ReadLine());
                        if (precoPeca <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Um valor negativo não é permitido");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            numeroValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor digitado não é permitido");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                numeroValido = false;
                while (numeroValido == false)
                {
                    Console.Write("Digite o nome da peça: ");
                    nomePeca = Console.ReadLine();
                    if (nomePeca.Length > 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da peça não ser maior que quinze caracteres");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (nomePeca.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da peça não ser menor que dois caracteres");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        numeroValido = true;
                    }
                }
                texto = texto + nomePeca + "                  " + precoPeca + "\n";
            }
            Console.WriteLine(texto);
        }
    }
}



