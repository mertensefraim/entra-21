using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        internal readonly CidadeService _cidadeService;
        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            AtualizarECadastrarDadosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeCadastroEdicaoForm();
            cidadeForm.ShowDialog();

            AtualizarECadastrarDadosDataGridView();
        }

        private void AtualizarECadastrarDadosDataGridView()
        {
            var cidades = _cidadeService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.QuantidadeHabitantes,
                    cidade.DataHoraFundacao.ToString("dd/MM/yyyy HH:mm:ss"),
                    cidade.Pib,
                    cidade.UnidadeFederativa.Nome,
                    cidade.UnidadeFederativa.Sigla
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cidade = _cidadeService.ObterPorId(id);

            var cidadeFederativaForm = new CidadeCadastroEdicaoForm(cidade);
            cidadeFederativaForm.ShowDialog();

            AtualizarECadastrarDadosDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _cidadeService.Apagar(id);

            MessageBox.Show("Registro apagado com sucesso");

            AtualizarECadastrarDadosDataGridView();
        }
    }
}
