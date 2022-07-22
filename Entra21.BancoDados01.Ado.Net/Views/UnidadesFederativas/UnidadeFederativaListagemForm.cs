using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        internal readonly UnidadeFederativaService _unidadeFederativaService;
        internal readonly MenuPrincipalForm _menuPrincipalForm;

        public UnidadeFederativaListagemForm(MenuPrincipalForm menuPrincipalForm)
        {
            InitializeComponent();

            _menuPrincipalForm = menuPrincipalForm;

            _unidadeFederativaService = new UnidadeFederativaService();

            AtualizarECadastrarDadosDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var resposta = MessageBox.Show($"Deseja realmente apagar a unidade Federativa com ID igual {id}", "Aviso", MessageBoxButtons.YesNo);

            if(resposta == DialogResult.No)
            {
                return;
            }

            try
            {
                _unidadeFederativaService.Apagar(id);

                AtualizarECadastrarDadosDataGridView();

                MessageBox.Show("Registro apagado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Não foi possível apagar essa unidade federativa, pois ela está sendo utilizada em alguma cidade");
            }
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

            var unidadeFederativa = _unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);
            unidadeFederativaForm.ShowDialog();

            AtualizarECadastrarDadosDataGridView();
        }

        private void AtualizarECadastrarDadosDataGridView()
        {
            var unidadesFederativas = _unidadeFederativaService.ObterTodos();

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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Close();
            _menuPrincipalForm.WindowState = FormWindowState.Normal;
        }

        private void UnidadeFederativaListagemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _menuPrincipalForm.WindowState = FormWindowState.Normal;
        }
    }
}
