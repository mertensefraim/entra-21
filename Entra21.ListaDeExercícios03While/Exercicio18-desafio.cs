using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio18_desafio
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de nomes que deseja cadastrar: ");
            var quantidadeNomes = Convert.ToInt32(Console.ReadLine());
            var texto = "";

            for (var i = 0; i < quantidadeNomes; i++)
            {
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine();
                if (i == quantidadeNomes - 1)
                {
                    texto += " e " + nome;
                }
                else if (i == quantidadeNomes - 2)
                {
                    texto += nome;
                }
                else
                {
                    texto += nome + ", ";
                }
            }
            Console.WriteLine(texto);
        }
    }
}
