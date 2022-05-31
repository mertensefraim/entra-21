using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio04
{
    public class Farmacia
    {
        public string RazaoSocial;
        public string Cnpj;
        public string[] NomesProdutos = new string[3];
        public double[] PrecosProdutos = new double[3];
        public string[] CategoriasProdutos = new string[3];

        public double ObterTotalDoPedido()
        {
            var somaProdutos = 0.0;
            for (var i = 0; i < PrecosProdutos.Length; i++)
            {
                somaProdutos += PrecosProdutos[i];
            }
            return somaProdutos;
        }

        public double ObterTotalAntiinflamatorios()
        {
            var valorAntiinflamatorios = 0.0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "antiinflamatório")
                    valorAntiinflamatorios += PrecosProdutos[i];
            }
            return valorAntiinflamatorios;
        }

        public double ObterTotalAntibioticos()
        {
            var valorAntibioticos = 0.0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            { 
                if (CategoriasProdutos[i] == "antibiótico")
                    valorAntibioticos += PrecosProdutos[i];
            }
            return valorAntibioticos;
        }

        public double ObterTotalAnalgesicos()
        {
            var valorAnalgesicos = 0.0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "analgésico")
                    valorAnalgesicos += PrecosProdutos[i];
            }
            return valorAnalgesicos;
        }

        public double ObterTotalAspirina()
        {
            var valorAspirina = 0.0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "aspirina")
                    valorAspirina += PrecosProdutos[i];
            }
            return valorAspirina;
        }

        public int ObterQuantidedeAntiinflamatorios()
        {
            var quantidadeAntiinflamatorios = 0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "antiinflamatório")
                    quantidadeAntiinflamatorios++;
            }
            return quantidadeAntiinflamatorios;
        }

        public int ObterQuantidadeAntibioticos()
        {
            var quantidadeAntibioticos = 0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "antibiótico")
                    quantidadeAntibioticos++;
            }
            return quantidadeAntibioticos;
        }

        public int ObterQuantidadelAnalgesicos()
        {
            var quantidadeAnalgesicos = 0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "analgésico")
                    quantidadeAnalgesicos++;
            }
            return quantidadeAnalgesicos;
        }

        public int ObterQuantidadeAspirina()
        {
            var quantidadeAspirina = 0;
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (CategoriasProdutos[i] == "aspirina")
                    quantidadeAspirina++;
            }
            return quantidadeAspirina;
        }

        public string ObterNomeProdutoMaisCaro()
        {
            var maiorValor = double.MinValue;
            var nomeProdutoMaisCaro = "";
            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (PrecosProdutos[i] > maiorValor)
                {
                    maiorValor = PrecosProdutos[i];
                    nomeProdutoMaisCaro = NomesProdutos[i];
                }
            }
            return nomeProdutoMaisCaro;
        }

        public string ObterNomeECategoriaProdutoMaisBarato()
        {
            var menorValor = double.MaxValue;
            var nomeProdutoMaisBarato = "";
            var nomeCategoriaMaisBarato = "";

            for (var i = 0; i < CategoriasProdutos.Length; i++)
            {
                if (PrecosProdutos[i] < menorValor)
                {
                    menorValor = PrecosProdutos[i];
                    nomeProdutoMaisBarato = NomesProdutos[i];
                    nomeCategoriaMaisBarato = CategoriasProdutos[i];
                }
            }
            return nomeProdutoMaisBarato + " e " + nomeCategoriaMaisBarato;
        }
    }
}
