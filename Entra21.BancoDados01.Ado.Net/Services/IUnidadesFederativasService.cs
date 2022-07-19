using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface IUnidadesFederativasService
    {
        void Cadastrar(UnidadeFederativa unidadesFederativas);
        void Editar(UnidadeFederativa unidadesFederativas);
        List<UnidadeFederativa> ObterTodos();
        void Apagar(int id);
        UnidadeFederativa ObterPorId(int id);
    }
}
