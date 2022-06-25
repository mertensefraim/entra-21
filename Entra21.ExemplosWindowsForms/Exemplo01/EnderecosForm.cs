using Newtonsoft.Json;
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
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instaciado o objeto de PacienteServico que permitirá listar os pacientes no ComboBox e decorrente
            // disto será possível o usuário selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve preencher a tabela quuando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Irá preencher o ComboBox(campo de seleção) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();

            ObterDadosCep();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os paientes adiscionando ao ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPacientes.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void LimparDados()
        {
            maskedTextBoxCep.Text = String.Empty;
            textBoxEnderecoCompleto.Text = String.Empty;
            comboBoxPacientes.SelectedIndex = -1;

            dataGridViewEnderecoes.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPacientes.SelectedItem);

            // Executa o método ValidarDados que retornará um bool
            // Sendo true quando os dados forem válidos
            // False quando os dados forem inválidos
            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            // Verifica se os dados são inválidos para não dar continuidade no cadastro do serviço
            if (dadosValidos == false)
                return;

            // Verificar se não está em modo de edição, ou seja, modo de cadastro
            if (dataGridViewEnderecoes.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciente);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparDados();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            // Obter linha selecionada
            var linhaSelecionada = dataGridViewEnderecoes.SelectedRows[0];
            // Obter código que está na coluna oculta do DataGriedView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Construir o objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Atualizar os dados na lista de endereços e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string? nomePaciente)
        {
            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereco na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGriedView
            dataGridViewEnderecoes.Rows.Clear();


            // Percorrer cada um dos endereços adicionando uma nova linha na tabela
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obter endereco percorrido
                var endereco = enderecos[i];

                dataGridViewEnderecoes.Rows.Add(new object[] {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });

                // Remover a seleção do dataGriedView
                dataGridViewEnderecoes.ClearSelection();
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", String.Empty).Trim();

            if (cep.Length != 8)
                return;

            // HttpCliente permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o Site ViaCep para obter dados de enderço de cep
            var resultado = httpClient.GetAsync(
                $"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (comboBoxPacientes.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxPacientes.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Verificar se algum item do DataGriedView está selecionado
            if (dataGridViewEnderecoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um endereço para remover");

                return;
            }
            // Questionar se o usuário realmente deseja apagar
            var resposta = MessageBox.Show("Deseja realmente apagar o endereço", "Aviso", MessageBoxButtons.YesNo);

            // Validar que o usuário não escolheu sim, pq não deverá continuar executando o código abaixo
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa, teu registro ta ali salvo");

                return;
            }
            // Qual item será apagado
            var linhaSelecionada = dataGridViewEnderecoes.SelectedRows[0];

            // Obter o código da linha selecionada na primeira coluna, que não está sendo apresentada para o usuário
            // que é referente ao código do endereço
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // ✓ Apagar o item da lista de itens no serviço
            // ✓ Atualizar o arquivo JSON

            // Buscar o endereço da lista de endereços filtrando por código
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apagar o endereço encontrado da lista de endereços e atualizar o arquivo JSON
            enderecoServico.Apagar(endereco);

            // Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            // Remover a seleção do DataGridView
            dataGridViewEnderecoes.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewEnderecoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridViewEnderecoes.SelectedRows[0];

            // Obter o código do endereço que o usuário selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter o endereço escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apresentar os dados de endereço na tela para edição
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPacientes.SelectedItem = endereco.Paciente.Nome;
        }

        // Quando o formulário é carregado apresenta os dados no DataGridView
        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridViewEnderecoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }
}
