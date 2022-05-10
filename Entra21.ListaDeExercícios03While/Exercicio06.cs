using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio06
    {
        //public void Executar()
        //{
        //    string nomeProduto = "";
        //    double valorProduto = 0, valorTotalCompra = 0;
        //    int quantidadeProduto = 0;
        //    while(nomeProduto != "sair")
        //    {
        //        Console.Write("Digite o nome do produto: ");
        //        nomeProduto = Console.ReadLine().ToLower().Trim();
        //        if(nomeProduto != "sair")
        //        {
        //            Console.Write("Digite o valor do produto: ");
        //            valorProduto = Convert.ToDouble(Console.ReadLine());
        //            Console.Write("Digite a quantidade do produto: ");
        //            quantidadeProduto = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        //            double valorTotalProdutos = valorProduto * quantidadeProduto;
        //            valorTotalCompra = valorTotalCompra + valorTotalProdutos;
        //        }
        //    }
        //    double valorTotalDesconto = valorTotalCompra - valorTotalCompra * 0.05;
        //    Console.WriteLine("O valor da compra com o desconto de 5% foi de R$" + valorTotalDesconto);
        //}
        public void Executar()
        {
            double valorProduto = 0, valorTotalCompra = 0;
            int quantidadeProduto = 0;

            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine().ToLower().Trim();

            while (nomeProduto != "sair")
            {


                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a quantidade do produto: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                double valorTotalProdutos = valorProduto * quantidadeProduto;
                valorTotalCompra = valorTotalCompra + valorTotalProdutos;

                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();
            }

            double valorDesconto = valorTotalCompra * 0.05;
            double valorTotalDesconto = valorTotalCompra - valorDesconto;
            Console.WriteLine("O valor da compra com o desconto de 5% foi de R$" + valorTotalDesconto);
        }
    }
}
