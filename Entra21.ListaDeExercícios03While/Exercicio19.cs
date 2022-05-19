using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio19
    {
        public void Executar()
        {
            var texto = "";
            var textoFinal = "";
            var nome = "";
            var nomeAtual = "";

            while (nome != "fim")
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine().ToLower().Trim();

                if (nome != "fim")
                {
                    nomeAtual = nome;
                    texto += nome + ", ";
                }
                else
                {
                    var caracteresTexto = texto.Length;
                    var indexNomeAtual = texto.IndexOf(nomeAtual);

                    texto = texto.Substring(0, indexNomeAtual - 2);
                    textoFinal = texto + " e " + nomeAtual;
                }
            }
            Console.WriteLine(textoFinal);
        }
    }
}
