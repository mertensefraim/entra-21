using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio04
{
    public class ExemploFarmacia
    {
        public void Executar()
        {
            var farmacia = new Farmacia();

            farmacia.NomesProdutos[0] = "Dorflex";
            farmacia.NomesProdutos[1] = "Gegrad";
            farmacia.NomesProdutos[2] = "Hakutan";

            farmacia.CategoriasProdutos[0] = "antiinflamatório";
            farmacia.CategoriasProdutos[1] = "antibiótico";
            farmacia.CategoriasProdutos[2] = "analgésico";

            farmacia.PrecosProdutos[0] = 22.5;
            farmacia.PrecosProdutos[1] = 20.5;
            farmacia.PrecosProdutos[2] = 45.75;

            Console.WriteLine($"Total do pedido: {farmacia.ObterTotalDoPedido()}" +
                $"\nTotal do pedido por categoria: " +
                $"\n    -Antiinflamatório: {farmacia.ObterTotalAntiinflamatorios()}" +
                $"\n    -Antibióticos: {farmacia.ObterTotalAntibioticos()}" +
                $"\n    -Analgésico: {farmacia.ObterTotalAnalgesicos()}" +
                $"\n    -Aspirina: {farmacia.ObterTotalAspirina()} " +
                $"\nTotal de quantidade por categoria: " +
                $"\n    -Antiinflamatório: {farmacia.ObterQuantidedeAntiinflamatorios()}" +
                $"\n    -Antibióticos: {farmacia.ObterQuantidadeAntibioticos()}" +
                $"\n    -Analgésico: {farmacia.ObterQuantidadelAnalgesicos()}" +
                $"\n    -Aspirina: {farmacia.ObterQuantidadeAspirina()}" +
                $"\nProduto mais caro: {farmacia.ObterNomeProdutoMaisCaro()}" +
                $"\nNome e categoria do produto mais caro: {farmacia.ObterNomeECategoriaProdutoMaisBarato()}");
        }
    }
}
