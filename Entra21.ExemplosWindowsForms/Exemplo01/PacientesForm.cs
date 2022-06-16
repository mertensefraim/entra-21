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
    public partial class PacientesForm : Form
    {
        private int codigo = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            var imc = peso / Math.Pow(altura, 2);

            // Verifica se está em modo de adição
            if (indiceLinhaSelecionada == -1)
            {
                dataGridViewInformacoes.Rows.Add(new object[]
                {
                codigo++, nome, altura, peso, imc
                });

                return;
            }

            dataGridViewInformacoes.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridViewInformacoes.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridViewInformacoes.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridViewInformacoes.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();
            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Pegar o indice da linha selecionada
            var indiceLinhaSelecionada = dataGridViewInformacoes.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente!!!");
                return;
            }

            var opcaoEscolhida = MessageBox.Show(
                "Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Veridica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o indice do DataGriedView
                dataGridViewInformacoes.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridViewInformacoes.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridViewInformacoes.SelectedRows[0];

            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();

        }
    }
}
