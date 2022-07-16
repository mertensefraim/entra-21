using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe
    // será obrigada a implementar os métodos(contratos) estabelecidos
    // na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            // Conectar com o bd
            var conexao = new Conexao().Conectar();

            // Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            // Executando o comando
            comando.ExecuteNonQuery();

            // Fechar conexão com o bd
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Será descrito a implementação do
            // contrato definido com a Interface

            var conexao = new Conexao().Conectar();

            // Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // especificando o comando que será executado
            comando.CommandText = 
                "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            // Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            // Conectando no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText =
                $"UPDATE tipos_personagens SET tipo = '{tipoPersonagem.Tipo}' WHERE id = '{tipoPersonagem.Id}'";

            // Executa o UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            // Fechar conexão
            comando.Connection.Close();
        }

        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = $"SELECT id, tipo FROM tipos_personagens WHERE id = '{id}'";

            // Instaciando tabela em memória para armazaenar os registros
            // retornados da consulta SELECT
            var tabelaEmMemoria = new DataTable();

            // Executado a consulta na tabela de tipos_personagens armazenando-os
            // na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if(tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();
            // Obter a primeira coluna do select que é o ID
            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro[0]);
            // Obter a primeira coluna do select que é o tipo
            tipoPersonagem.Tipo = primeiroRegistro[1].ToString();

            // Fechar conexão
            comando.Connection.Close();

            return tipoPersonagem;
        }

        public List<TipoPersonagem> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            // Criando tabela em memória para posteriormente carregar os
            // registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            // Carregando na tabela em memóra os registros encontrados
            // com o comado SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            // Percorrido cada um dos regitros da
            // tabelaEmMemoria(registros do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                // Instanciado objeto da classe TipoPersonagem
                // Preenchendo com as informações do SELECT, da linha
                // que está sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                // Adicionado tipoPersonagem instaciado na lista
                // de TiposPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }
            // Fechar conexão com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}
