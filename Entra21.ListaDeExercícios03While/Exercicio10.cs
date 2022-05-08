using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());
            int indice = 0, numerosAntecessores = numeroUsuario, numerosSucessores = numeroUsuario;
            string numerosSucessoresResultado = "", numerosAntecessoresResultado = "";
            while (indice < 100)
            {
                numerosAntecessores = numerosAntecessores - 1;
                numerosSucessores = numerosSucessores + 1;

                if(numerosAntecessores % 2 == 0)
                {
                    numerosAntecessoresResultado = numerosAntecessoresResultado + numerosAntecessores + "|";
                }
                if (numerosAntecessores % 2 != 0)
                {
                    numerosSucessoresResultado = numerosSucessoresResultado + numerosSucessores + "|";
                }
                indice = indice + 1;
            }
            Console.WriteLine("Antecessores pares: " + numerosAntecessoresResultado +
                "\n\nSucessores ímpares: " + numerosSucessoresResultado);
        }
    }
}
