using Entra21.BancoDados01.Ado.Net.Models;
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

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        internal readonly UnidadeFederativaService _UnidadeFederativaService;

        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            _UnidadeFederativaService = new UnidadeFederativaService();

            AtualizarECadastrarDadosDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _UnidadeFederativaService.Apagar(id);

            AtualizarECadastrarDadosDataGridView();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm();
            unidadeFederativaForm.ShowDialog();

            AtualizarECadastrarDadosDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = _UnidadeFederativaService.ObterPorId(id);

            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);
            unidadeFederativaForm.ShowDialog();

            AtualizarECadastrarDadosDataGridView();
        }

        private void AtualizarECadastrarDadosDataGridView()
        {
            var unidadesFederativas = _UnidadeFederativaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];
                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }
    }
}
