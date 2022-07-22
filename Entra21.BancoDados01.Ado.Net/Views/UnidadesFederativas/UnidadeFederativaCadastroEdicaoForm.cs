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
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        internal readonly UnidadeFederativaService _UnidadeFederativaService;
        internal int _idParaEditar = -1;

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();

            _UnidadeFederativaService = new UnidadeFederativaService();
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            _idParaEditar = unidadeFederativa.Id;

            textBoxNome.Text = unidadeFederativa.Nome;
            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var unidadeFederativa = new UnidadeFederativa();

            unidadeFederativa.Nome = textBoxNome.Text.Trim();
            unidadeFederativa.Sigla = textBoxSigla.Text.Trim();

            if (ValidarCampos() == false)
                return;
            
            if (_idParaEditar == -1)
            {
                _UnidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso");
            }
            else
            {
                _UnidadeFederativaService.Editar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa editada com sucesso");
            }
            

            Close();
        }

        private bool ValidarCampos()
        {
            if (textBoxNome.Text.Trim().Length < 4 || textBoxNome.Text.Trim().Length > 20)
            {
                MessageBox.Show("A quantidade de caracteres do campo nome não é a correta");
                textBoxNome.Focus();
                return false;
            }

            if (textBoxSigla.Text.Trim().Length != 2)
            {
                MessageBox.Show("O tamanho da sigla deve ser de 2 caracteres");
                textBoxSigla.Focus();
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
