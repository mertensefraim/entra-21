  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio09
    {
        //public void Executar()
        //{
        //    Console.Write("Digite um número: ");
        //    int numeroUsuario = Convert.ToInt32(Console.ReadLine());
        //    int indice = 0, fatorialResultado = numeroUsuario;
        //    while (indice < numeroUsuario)
        //    {
        //        if(indice != 0)
        //        {
        //            fatorialResultado = fatorialResultado * indice;
        //        }
        //        indice = indice + 1;
        //    }
        //    Console.WriteLine(fatorialResultado);
        //}
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());
            int indice = numeroUsuario - 1, fatorialResultado = numeroUsuario;
            while (indice > 1)
            {
                fatorialResultado = fatorialResultado * indice;

                indice = indice - 1;
            }
            Console.WriteLine(fatorialResultado);
        }
    }
}
