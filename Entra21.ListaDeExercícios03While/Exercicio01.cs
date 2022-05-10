using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;
            string texto = "";
            while (indice < 13)
            {
                Console.Write("Digite o preço da peça: ");
                double precoPeca = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o nome da peça: ");
                string nomePeca = Console.ReadLine();

                texto = texto + "Preço peça: " + precoPeca + "      " + "Nome peça: " + nomePeca + "\n";
                indice = indice + 1;
            }
            Console.WriteLine(texto);
        }
    }
}
