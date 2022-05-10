using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio15
    {
        public void Executar()
        {
            Console.Write("Digite uma frase: ");
            string fraseUsuario = Console.ReadLine();

            int indice = 0;

            while (indice < fraseUsuario.Length)
            {
                Console.WriteLine(fraseUsuario.Substring(indice, 1));
                indice = indice + 1;
            }
        }
    }
}
