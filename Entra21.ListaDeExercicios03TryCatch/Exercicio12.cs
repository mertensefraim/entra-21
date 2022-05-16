using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio12
    {
        public void Executar()
        {
            var numeroUsuario = 0;
            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var QuantidadeSanduiches = 0;
            var quantidadePizzas = 0;
            var valorProduto = 0.0;
            var somaProdutos = 0.0;

            while (numeroUsuario != 16)
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

                var verificador = false;
                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Digite um número correspondente ao produto desejado: ");
                        numeroUsuario = Convert.ToInt32(Console.ReadLine());
                        if (numeroUsuario <= 0 || numeroUsuario > 16)
                        {
                            Console.WriteLine("Essa opção não existe!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O valor não é um número inteiro!!!");
                    }
                }


                if (numeroUsuario >= 1 && numeroUsuario <= 5)
                {
                    quantidadeBolos++;
                    if (numeroUsuario == 1)
                    {
                        valorProduto = 29.5;
                    }
                    else if (numeroUsuario == 2)
                    {
                        valorProduto = 2.0;
                    }
                    else if (numeroUsuario == 3)
                    {
                        valorProduto = 29.23;
                    }
                    else if (numeroUsuario == 4)
                    {
                        valorProduto = 7.10;
                    }
                    else if (numeroUsuario == 5)
                    {
                        valorProduto = 19.33;
                    }
                }
                else if (numeroUsuario == 6 || numeroUsuario == 7)
                {
                    quantidadeDoces++;
                    if (numeroUsuario == 6)
                    {
                        valorProduto = 17.71;
                    }
                    else if (numeroUsuario == 7)
                    {
                        valorProduto = 4.82;
                    }
                }
                else if (numeroUsuario >= 8 && numeroUsuario <= 11)
                {
                    QuantidadeSanduiches++;
                    if (numeroUsuario == 8)
                    {
                        valorProduto = 21.16;
                    }
                    else if (numeroUsuario == 9)
                    {
                        valorProduto = 12.70;
                    }
                    else if (numeroUsuario == 10)
                    {
                        valorProduto = 19.70;
                    }
                    else if (numeroUsuario == 11)
                    {
                        valorProduto = 28.22;
                    }
                }
                else if (numeroUsuario >= 12 && numeroUsuario <= 15)
                {
                    quantidadePizzas++;
                    if (numeroUsuario == 12)
                    {
                        valorProduto = 8.98;
                    }
                    else if (numeroUsuario == 13)
                    {
                        valorProduto = 0.42;
                    }
                    else if (numeroUsuario == 14)
                    {
                        valorProduto = 18.36;
                    }
                    else if (valorProduto == 15)
                    {
                        valorProduto = 27.5;
                    }
                }
                somaProdutos += valorProduto;
            }
            var mediaProdutos = somaProdutos / (quantidadeBolos + quantidadeDoces + quantidadePizzas + QuantidadeSanduiches);
            Console.WriteLine("Quantidade de bolos escolhidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de doces escolhidos: " + quantidadeDoces);
            Console.WriteLine("Quantidade de sanduíches escolhidos: " + QuantidadeSanduiches);
            Console.WriteLine("Quantidade de pizzas escolhidas: " + quantidadePizzas);
            Console.WriteLine("Média dos produtos: " + mediaProdutos);
        }
    }
}