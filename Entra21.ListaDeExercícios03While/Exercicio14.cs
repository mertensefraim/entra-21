using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio14
    {
        public void Executar()
        {
            Console.Write("Quantos caracteres serão digitados: ");
            int quantidadeUsuario = Convert.ToInt32(Console.ReadLine()), indice = 0;
            string fraseUsuario = "";
            while (indice < quantidadeUsuario)
            {
                Console.Write("Caracter: ");
                char caracteresUsuario = Console.ReadLine()[0];

                fraseUsuario = fraseUsuario + caracteresUsuario; 
                indice = indice + 1;
            }
            Console.Write(fraseUsuario);
        }
    }
}
