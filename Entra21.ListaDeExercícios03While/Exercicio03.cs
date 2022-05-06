using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int idadeUsuario = int.MinValue;
            string texto = "";
            while (idadeUsuario < 128)
            {
                Console.Write("Digite sua idade: ");
                idadeUsuario = Convert.ToInt32(Console.ReadLine());
                texto = texto + idadeUsuario + "\n";
            }
            Console.WriteLine(texto);

        }
    }
}
