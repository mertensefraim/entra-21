using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);
        void Editar(Cidade cidade);
        void Apagar(int id);
        List<Cidade> ObterTodos();
        Cidade ObterPorId(int id);
    }
}
