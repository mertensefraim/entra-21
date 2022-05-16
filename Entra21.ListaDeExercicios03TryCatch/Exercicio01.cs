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
                        if (precoPeca < 0)
                        {
                            Console.WriteLine("Um valor negativo não é permitido");
                        }
                        else
                        {
                            numeroValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O valor digitado não é permitido");
                    }
                }

                numeroValido = false;
                while (numeroValido == false)
                {
                    Console.Write("Digite o nome da peça: ");
                    nomePeca = Console.ReadLine();
                    if (nomePeca.Length > 15)
                    {
                        Console.WriteLine("O nome da peça não ser maior que quinze caracteres");
                    }
                    else if (nomePeca.Length < 2)
                    {
                        Console.WriteLine("O nome da peça não ser menor que dois caracteres");
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



