using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            double numeroTabuada = Convert.ToDouble(Console.ReadLine());
            int indice = 0;
            while (indice < 1001)
            {

                Console.WriteLine(numeroTabuada + " X " + indice + " = " + (numeroTabuada * indice));

                indice = indice + 1;
            }

        }
    }
}
