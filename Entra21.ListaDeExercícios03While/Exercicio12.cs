using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio12
    {
        public void Executar()
        {
            Console.WriteLine(@"
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-Tabela de Alimentos-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

01------Bolos-------------------------Bolo Brigadeiro------------------------------------------------R$ 29,50
02------Bolos-------------------------Bolo Floresta Negra--------------------------------------------R$ 2,00
03------Bolos-------------------------Bolo Leite com Nutella-----------------------------------------R$ 29,23
04------Bolos-------------------------Bolo Mousse de Chocolate---------------------------------------R$ 7,10
05------Bolos-------------------------Bolo Nega Maluca-----------------------------------------------R$ 19,33
06------Doces-------------------------Bomba de Creme-------------------------------------------------R$ 17,71
07------Doces-------------------------Bomba de Morango-----------------------------------------------R$ 4,82
08------Sanduíches--------------------Filé-Mignon com fritas e cheddar-------------------------------R$ 21,16
09------Sanduíches--------------------Hambúrguer com queijos, champignon e rúcula--------------------R$ 12,70
10------Sanduíches--------------------Provolone com salame-------------------------------------------R$ 19,70
11------Sanduíches--------------------Vegetariano de berinjela---------------------------------------R$ 28,22
12------Pizzas------------------------Calabresa------------------------------------------------------R$ 8,98
13------Pizzas------------------------Napolitana-----------------------------------------------------R$ 0,42
14------Pizzas------------------------Peruana--------------------------------------------------------R$ 18,36
15------Pizzas------------------------Portuguesa-----------------------------------------------------R$ 27,50
16------------------------------------Sair------------------------------------------------------------------");
            int valorDesejado = 0, quantidadeBolos = 0, quantidadeDoces = 0, quantidadeSanduiches = 0, quantidadePizzas = 0;
            double valorProdutos = 0;
            while (valorDesejado != 16)
            {
                Console.Write("Digite o valor desejado: ");
                valorDesejado = Convert.ToInt32(Console.ReadLine());
                if (valorDesejado == 1)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorProdutos = valorProdutos + 29.50;
                }
                else if (valorDesejado == 2)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorProdutos = valorProdutos + 2;
                }
                else if (valorDesejado == 3)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorProdutos = valorProdutos + 29.23;
                }
                else if (valorDesejado == 4)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorProdutos = valorProdutos + 7.10;
                }
                else if (valorDesejado == 5)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorProdutos = valorProdutos + 19.33;
                }
                else if (valorDesejado == 6)
                {
                    quantidadeDoces = quantidadeDoces + 1;
                    valorProdutos = valorProdutos + 17.71;
                }
                else if (valorDesejado == 7)
                {
                    quantidadeDoces = quantidadeDoces + 1;
                    valorProdutos = valorProdutos + 4.82;
                }
                else if (valorDesejado == 8)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    valorProdutos = valorProdutos + 21.16;
                }
                else if (valorDesejado == 9)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    valorProdutos = valorProdutos + 12.7;
                }
                else if (valorDesejado == 10)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    valorProdutos = valorProdutos + 19.7;
                }
                else if (valorDesejado == 11)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    valorProdutos = valorProdutos + 28.22;
                }
                else if (valorDesejado == 12)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    valorProdutos = valorProdutos + 8.98;
                }
                else if (valorDesejado == 13)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    valorProdutos = valorProdutos + 0.42;
                }
                else if (valorDesejado == 14)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    valorProdutos = valorProdutos + 18.36;
                }
                else if (valorDesejado == 15)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    valorProdutos = valorProdutos + 27.50;
                }
            }
            double mediaProdutos = valorProdutos / (quantidadeBolos + quantidadeDoces + quantidadeSanduiches + quantidadePizzas);
            Console.WriteLine("Quantidade de bolos escolhidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de doces escolhidos: " + quantidadeDoces);
            Console.WriteLine("Quantidade de sanduíches escolhidos: " + quantidadeSanduiches);
            Console.WriteLine("Quantidade de pizzas escolhidas: " + quantidadePizzas);
            Console.WriteLine("Média dos produtos: " + mediaProdutos);
        }
    }
}
