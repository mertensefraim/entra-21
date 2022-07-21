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

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        internal int _idParaEditar = -1;
        internal readonly CidadeService _CidadeService;

        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
            _CidadeService = new CidadeService();

            PreencherComboBoxUnidadeFederativa();
        }

        public CidadeCadastroEdicaoForm(Cidade cidade)
        {
            _idParaEditar = cidade.Id;

            textBoxNome.Text = cidade.Nome;
            maskedTextBoxPib.Text = cidade.Pib.ToString();
            dateTimePickerDataHoraFundacao.Value = cidade.DataHoraFundacao;

            for (int i = 0; i < comboBoxUnidadeFederativa.Items.Count; i++)
            {
                var unidadeFederativaPercorrida = comboBoxUnidadeFederativa.Items[i] as UnidadeFederativa;

                if (unidadeFederativaPercorrida.Id == cidade.UnidadeFederativa.Id)
                {
                    comboBoxUnidadeFederativa.SelectedItem = unidadeFederativaPercorrida;
                    break;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma unidade federativa");
                return;
            }

            var unidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;

            var cidade = new Cidade();
            cidade.Nome = textBoxNome.Text;
            cidade.UnidadeFederativa = unidadeFederativa;
            cidade.Pib = Convert.ToDecimal(maskedTextBoxPib.Text);
            cidade.DataHoraFundacao = Convert.ToDateTime(dateTimePickerDataHoraFundacao);

            if (_idParaEditar == -1)
            {
                _CidadeService.Cadastrar(cidade);

                MessageBox.Show("Cidade cadastrada com sucesso");
            }
            else
            {
                cidade.Id = _idParaEditar;

                _CidadeService.Editar(cidade);

                MessageBox.Show("Cidade editada com sucesso");
                Close();
            }
        }

        private void PreencherComboBoxUnidadeFederativa()
        {
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidades = unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidades.Count; i++)
            {
                var unidade = unidades[i];
                comboBoxUnidadeFederativa.Items.Add(unidade);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
