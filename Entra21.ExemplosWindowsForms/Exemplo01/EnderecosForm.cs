using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = String.Empty;
            textBoxEnderecoCompleto.Text = String.Empty;
            comboBoxPacientes.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var paciente = comboBoxPacientes.SelectedItem;

            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            // endereco.Paciente = paciente;

            // Salvar este endereco na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            //TODO: adicionar ele na lista de DataGridView

        }
    }
}
