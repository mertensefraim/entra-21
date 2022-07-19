using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class UnidadeFederativaService : IUnidadesFederativasService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadesFederativas)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO unidades_federativas (nome, sigla) VALUES (@NOME, @SIGLA);";
            comando.Parameters.AddWithValue("@NOME", unidadesFederativas.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadesFederativas.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(UnidadeFederativa unidadesFederativas)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE id = @ID;";
            comando.Parameters.AddWithValue("@NOME", unidadesFederativas.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadesFederativas.Sigla);
            comando.Parameters.AddWithValue("@ID", unidadesFederativas.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var unidadeFederativas = new UnidadeFederativa();

            unidadeFederativas.Nome = registro["nome"].ToString();
            unidadeFederativas.Sigla = registro["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativas;
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas;";

            var tabelaEmMemoria = new DataTable();
            
            var unidadesFederativas = new List<UnidadeFederativa>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var unidadeFederativa = new UnidadeFederativa();
                unidadeFederativa.Nome = registro["nome"].ToString();
                unidadeFederativa.Sigla = registro["sigla"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }
            comando.Connection.Close();

            return unidadesFederativas;
        }
    }
}
