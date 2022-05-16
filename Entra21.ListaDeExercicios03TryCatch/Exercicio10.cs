using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio10
    {
        public void Executar()
        {
            var antecessoresResultado = "";
            var sucessoresResultado = "";
            var numeroUsuario = 0;
            var verificador = false;

            while (verificador == false)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());
                    verificador = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor não é um inteiro!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            var antecessores = numeroUsuario;
            var sucessores = numeroUsuario;

            for (var i = 0; i <= 100; i++)
            {
                antecessores--;
                sucessores++;
                if (antecessores % 2 == 0)
                {
                    antecessoresResultado = antecessoresResultado + antecessores + "|";
                }
                else if (sucessores % 2 != 0)
                {
                    sucessoresResultado = sucessoresResultado + sucessores +  "|";
                }
            }

            Console.WriteLine("Os antecessores pares são: " + antecessoresResultado);
            Console.WriteLine("Os sucessores ímpares são: " + sucessoresResultado);
        }
    }
}
