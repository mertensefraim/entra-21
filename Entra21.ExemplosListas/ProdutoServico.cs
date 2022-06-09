using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosListas
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Instanciar um objeto de classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar o produto instaciando na lista de produtos
            produtos.Add(produto);
        }

        public void Editar()
        {

        }

        public void Apagar()
        {

        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
