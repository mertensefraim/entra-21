using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo, Autor, IdiomaOriginal, Isbn;
        public DateTime DataLancamento;
        public int QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;

        public string ApresentarTituloAutor()
        {
            var nomeAutor = Autor;
            var titulo = Titulo;

            return "Titulo: " + titulo +
                "\nAutor: " + Autor;
        }

        public int ApresentarQuantidadePaginasParaLer()
        {
            if (QuantidadePaginas >= QuantidadePaginasLidas)
            {
                return QuantidadePaginas - QuantidadePaginasLidas;
            }
            return 0;
        }

        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            return QuantidadePaginas * QuantidadeReleituras + QuantidadePaginasLidas;
        }
    }
}
