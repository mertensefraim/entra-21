using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio07
    {
        public void Executar()
        {
            string nomeProduto = "";
            double valorProduto = 0, valorTotalCompra = 0;
            int quantidadeProduto = 0, quantidadeProdutosTotal = 0;
            while (quantidadeProdutosTotal < 5)
            {
                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();
                Console.Write("Digite o valor do produto: R$");
                valorProduto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a quantidade do produto: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                quantidadeProdutosTotal = quantidadeProdutosTotal + quantidadeProduto;
                double valorTotalProdutos = quantidadeProduto * valorProduto;
                valorTotalCompra = valorTotalCompra + valorTotalProdutos;
            }

            double valorTotalDesconto = 0;

            if (valorTotalCompra - 150 >= 0)
            {
                valorTotalDesconto = valorTotalCompra - 150;
            }

            Console.WriteLine("O valor total da compra com R$150,00 de desconto foi de R$" + valorTotalDesconto);
        }
    }
}
