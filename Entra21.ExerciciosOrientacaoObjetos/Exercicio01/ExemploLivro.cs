using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();

            livro.Titulo = "Star Wars: Kenobi";
            livro.Autor = "John Jackson Miller";
            livro.IdiomaOriginal = "Inglês";
            livro.DataLancamento = new DateTime(2010, 07, 24);
            livro.Isbn = "231-321-321-321";
            livro.QuantidadePaginas = 532;
            livro.QuantidadePaginasLidas = 234;
            livro.QuantidadeReleituras = 3;

            var apresentarTituloAutor = livro.ApresentarTituloAutor();
            var quantidadePaginasLer = livro.ApresentarQuantidadePaginasParaLer();
            var quantidadeLidaTotal = livro.ApresentarQuantidadePaginasLidasNoTotal();

            Console.WriteLine($"Titulo e autor: {apresentarTituloAutor}" +
                $"\nQuantidade de páginas para ler: {quantidadePaginasLer}" +
                $"\nQuantidade de páginas lidas no total: {quantidadeLidaTotal}");


        }
    }
}
