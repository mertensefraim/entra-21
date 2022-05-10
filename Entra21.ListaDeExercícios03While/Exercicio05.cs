using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            int indice = 0, quantidadeCarrosG = 0, quantidadeCarrosA = 0;
            double somaValorCarros = 0, somaAnoCarros = 0;

            while (indice < quantidadeDesejada)
            {
                Console.Write("Digite o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToLower().Trim();
                Console.Write("Digite o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                somaAnoCarros = somaAnoCarros + anoCarro;
                somaValorCarros = somaValorCarros + valorCarro;

                if (modeloCarro.StartsWith("g"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("a"))
                {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }
                indice = indice + 1;
            }
            double mediaAnoCarros = somaAnoCarros / quantidadeDesejada;
            double mediaValorCarros = somaValorCarros / quantidadeDesejada;

            Console.WriteLine(@"Média dos anos dos carros: " + mediaAnoCarros +
                "\nMédia valor dos carros: " + mediaValorCarros +
                "\nQuantidade de carros que começam com a letra G: " + quantidadeCarrosG +
                "\nQuantidade de carros que começam com a letra A: " + quantidadeCarrosA);

        }
    }
}
