using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nomeUsuario = "", texto = "";
            while (nomeUsuario != "fim")
            {
                Console.Write("Digite seu nome: ");
                nomeUsuario = Console.ReadLine().Trim().ToLower();
                if (nomeUsuario != "fim")
                {
                    texto = texto + nomeUsuario + "\n";
                }
            }
            Console.WriteLine(texto);
        }
    }
}
