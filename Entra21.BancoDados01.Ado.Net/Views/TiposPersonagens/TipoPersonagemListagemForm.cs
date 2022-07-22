using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            // Instanciando objeto da classe TipoPersonagemService para permitir:
            // - Listar Todos
            // - Editar
            // - Apagar
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            // Obter todos os tipos de personagens cadastrados na tabela
            // tipos personaens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // Removido todos os registos do dataGriedView
            dataGridView1.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para 
            // adicionar no DataGriedView permitinfo o usuário visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso");

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Selecione algum tipo de personagem");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            // Obter a linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Ober o id da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter do banco de dados o tipo de personagem selecionado
            var tipoPersonagem = tipoPersonagemService.ObterPorId(id);

            // Instanciado objeto do form para permitira edição passando o tipo
            // personagem, que permitirá preencher os campos com os dados do Banco de Dados
            var tipoPersonagemForm = new TipoPersonagemCadastroEdicaoForm(tipoPersonagem);
            // Apresentar o form para o usuário
            tipoPersonagemForm.ShowDialog();

            AtualizarRegistrosDataGridView();

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new MenuPrincipalForm();
            menuPrincipal.ShowDialog();
        }
    }
}
