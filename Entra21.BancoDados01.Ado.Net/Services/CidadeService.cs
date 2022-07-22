using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO cidades (id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib) VALUES (@ID_UNIDADE, @NOME, @QUANTIDADE_HABITANTES, @DATA, @PIB);";
            comando.Parameters.AddWithValue("@ID_UNIDADE", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE cidades SET id_unidade_federativa = @ID_UNIDADE, nome = @NOME, quantidade_habitantes = @QUANTIDADE_HABITANTES, data_hora_fundacao = @DATA, pib = @PIB WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", cidade.Id);
            comando.Parameters.AddWithValue("@ID_UNIDADE", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var cidade = new Cidade();

            cidade.Id = Convert.ToInt32(registro["id"]);

            cidade.UnidadeFederativa = new UnidadeFederativa();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            cidade.Nome = registro["nome"].ToString();
            cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            cidade.Pib = Convert.ToDecimal(registro["pib"]);

            conexao.Close();

            return cidade;
        }

        public List<Cidade> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT 
c.id, 
c.nome, 
c.quantidade_habitantes, 
c.data_hora_fundacao, 
c.pib,
uf.nome AS 'nome_uf',
uf.sigla AS 'sigla_uf',
uf.id AS 'id_uf'
FROM cidades AS c
INNER JOIN unidades_federativas AS uf ON(c.id_unidade_federativa = uf.id)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var cidades = new List<Cidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cidade = new Cidade();

                cidade.Id = Convert.ToInt32(registro["id"]);

                cidade.Nome = registro["nome"].ToString();
                cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
                cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
                cidade.Pib = Convert.ToDecimal(registro["pib"]);

                cidade.UnidadeFederativa = new UnidadeFederativa();
                cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_uf"]);
                cidade.UnidadeFederativa.Nome = registro["nome_uf"].ToString(); 
                cidade.UnidadeFederativa.Sigla = registro["sigla_uf"].ToString();

                cidades.Add(cidade);
            }
           
            conexao.Close();

            return cidades;
        }
    }
}
