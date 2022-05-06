using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine()), indice = 0, fatorialResultado = 0, numeroFatorial = 0;
            while(indice < numeroUsuario)
            {
                if(indice != 0)
                {
                    numeroFatorial = numeroUsuario * (numeroUsuario - 1);
                }

                indice = indice + 1;
            }
        }
    }
}
