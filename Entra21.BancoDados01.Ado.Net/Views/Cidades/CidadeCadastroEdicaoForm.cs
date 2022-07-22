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

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idParaEditar = cidade.Id;

            textBoxNome.Text = cidade.Nome;
            textBoxPib.Text = cidade.Pib.ToString();
            dateTimePickerDataFundacao.Value = cidade.DataHoraFundacao;
            dateTimePickerHoraDeFundacao.Value = Convert.ToDateTime(cidade.DataHoraFundacao.ToString("HH:mm:ss"));
            textBoxQuantidadeHabitantes.Text = cidade.QuantidadeHabitantes.ToString();

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
            var unidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;

            if (ValidarCampos() == false)
                return;

            var cidade = new Cidade();
            cidade.Nome = textBoxNome.Text.Trim();
            cidade.UnidadeFederativa = unidadeFederativa;
            cidade.Pib = Convert.ToDecimal(textBoxPib.Text.Trim().Replace(".", ","));
            cidade.DataHoraFundacao = Convert.ToDateTime(dateTimePickerDataFundacao.Value.Date.ToString("dd/MM/yyyy") + " " + dateTimePickerHoraDeFundacao.Value.TimeOfDay);
            cidade.QuantidadeHabitantes = Convert.ToInt32(textBoxQuantidadeHabitantes.Text.Trim());

            if (_idParaEditar == -1)
            {
                _CidadeService.Cadastrar(cidade);

                MessageBox.Show("Cidade cadastrada com sucesso");
                Close();
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

        private bool ValidarCampos()
        {
            if (textBoxNome.Text.Trim().Length > 50 || textBoxNome.Text.Trim().Length < 3)
            {
                MessageBox.Show("O nome deve ter mais de 3 caracteres e menos de 50");
                textBoxNome.Focus();
                return false;
            }

            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma unidade federativa");
                comboBoxUnidadeFederativa.DroppedDown = true;
                return false;
            }

            try
            {
                Convert.ToDecimal(textBoxPib.Text.Trim().Replace(".", ","));

                if (textBoxPib.Text.Length > 15)
                {
                    MessageBox.Show("O valor do PIB não pode ser maior que 999999999999,99");
                    textBoxPib.Focus();
                    return false;
                }

                else if (textBoxPib.Text.Contains("-"))
                {
                    MessageBox.Show("O valor do PIB não pode ser negativo");
                    textBoxPib.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O valor do PIB deve ser um decimal válido");
                textBoxPib.Focus();
                return false;
            }

            try
            {
                Convert.ToInt32(textBoxQuantidadeHabitantes.Text);
            }
            catch
            {
                MessageBox.Show("O valor de habitantes deve ser um decimal válido");
                textBoxQuantidadeHabitantes.Focus();
                return false;
            }


            return true;
        }
    }
}
