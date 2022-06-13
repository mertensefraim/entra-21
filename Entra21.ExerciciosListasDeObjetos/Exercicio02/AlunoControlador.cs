using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio02
{
    internal class AlunoControlador
    {
        private AlunoServico AlunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            var codigo = 0;

            while (codigo != 13)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

                if (codigo == 1)
                    Cadastrar();

                else if (codigo == 2)
                    EditarInformacoesPessoais();

                else if (codigo == 3)
                    EditarNotas();

                else if (codigo == 4)
                    Apagar();

                else if (codigo == 5)
                    ListarTodosOsAlunos();

                else if (codigo == 6)
                    ListarNomesAlunos();

                else if (codigo == 7)
                    ListarAprovados();

                else if (codigo == 8)
                    ListarReprovados();

                else if (codigo == 9)
                    ListarEmExame();

                else if (codigo == 10)
                    ListarMediaAlunoEspecifico();

                else if (codigo == 11)
                    ListarStatusAlunoEspecifico();

                else if (codigo == 12)
                    ListarMediaIdades();

                Console.ReadKey();
            }
        }

        private void ListarMediaIdades()
        {
            Console.WriteLine($"A média das idades é {AlunoServico.ObterMediaIdades} anos");
        }

        private void ListarStatusAlunoEspecifico()
        {
            ListarTodosOsAlunos();

            Console.Write("Digite o código do aluno para obter a média: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var statusAluno = AlunoServico.ObterStatusPorCodigoMatricula(codigo);

            Console.WriteLine($"O status do aluno com código {codigo} é igual a {statusAluno}");
        }

        private void ListarMediaAlunoEspecifico()
        {
            ListarTodosOsAlunos();

            Console.Write("Digite o código do aluno para obter a média: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var mediaAluno = AlunoServico.ObterMediaPorCodigoMatricula(codigo);

            Console.WriteLine($"A média do aluno com código {codigo} é igual a {mediaAluno}");
        }

        private void ListarAprovados()
        {
            var nomes = "";
            var alunos = AlunoServico.ObterAprovados();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos aprovados são {nomes}");
        }

        private void ListarReprovados()
        {
            var nomes = "";
            var alunos = AlunoServico.ObterReprovados();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos reprovados são {nomes}");
        }

        private void ListarEmExame()
        {
            var nomes = "";
            var alunos = AlunoServico.ObterEmExame();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos em exame são {nomes}");
        }

        private void ListarNomesAlunos()
        {
            var nomes = "";
            var alunos = AlunoServico.ObterNomes();

            for (int i = 0; i < alunos.Count; i++)
            {
               nomes += alunos[i] + " | ";
            }

            Console.WriteLine($"O nome dos alunos são {nomes}");
        }

        private void Apagar()
        {
            ListarTodosOsAlunos();

            Console.WriteLine("Digite um nome: ");
            var nome = Console.ReadLine().ToLower().Trim;

            var apagou = AlunoServico.RemoverAluno(nome);

            if (apagou == true)
                Console.WriteLine("Aluno apagado com sucesso");

            else
                Console.WriteLine("Não foi possível apagar o aluno / :");
        }

        private void EditarNotas()
        {
            ListarTodosOsAlunos();

            Console.Write("Digite o código do aluno para editar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 01: ");
            var nota01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 02: ");
            var nota02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 03: ");
            var nota03 = Convert.ToDouble(Console.ReadLine());

            var editou = AlunoServico.EditarNotasAluno(codigo, nota01, nota02, nota03);

            if (editou == true)
                Console.WriteLine("Aluno editado com sucesso");

            else
                Console.WriteLine("Não foi possível editar o aluno / :");
        }

        private void EditarInformacoesPessoais()
        {
            ListarTodosOsAlunos();

            Console.Write("Digite o código da matrícula do aluno: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite uma idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a matéria favorita: ");
            var materiaFavorita = Console.ReadLine();

            var editou = AlunoServico.EditarDadosCadastrais(codigo, nome, idade, materiaFavorita);

            if (editou == true)
                Console.WriteLine("Aluno editado com sucesso");
            
            else
                Console.WriteLine("Não foi possível editar o aluno / :");
        }

        private void Cadastrar()
        {
            Console.Write("Digite um nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite uma idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a matéria favorita: ");
            var materiaFavorita = Console.ReadLine();

            Console.Write("Digite a nota 01: ");
            var nota01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 02: ");
            var nota02 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a nota 03: ");
            var nota03 = Convert.ToDouble(Console.ReadLine());

            AlunoServico.Adicionar(nome, idade, materiaFavorita, nota01, nota02, nota03);
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"=-=-=-=-=-= Menu =-=-=-=-=-=
01 - Cadastrar
02 - Editar informações pessoais
03 - Editar notas
04 - Apagar
05 - Listar todos os alunos
06 - Listar o nome de todos os alunos
07 - Listar alunos aprovados
08 - Listar alunos reprovados
09 - Listar alunos em exame
10 - Visualizar a média de um aluno específico
11 - Visualizar o status de um aluno específico
12 - Visualizar a média das idades
13 - Sair");

            var codigo = SolicitarCodigoMeni();

            return codigo;
        }

        private int SolicitarCodigoMeni()
        {
            var verificador = false;
            var codigo = 0;
            while (verificador == false)
            {
                try
                {
                    Console.Write("Digite o código desejado: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    if (codigo <= 0 || codigo > 13)
                        Console.WriteLine("O código deve ser maior que 0 e menor que 13");
                    else
                        verificador = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor digitado deve ser um inteiro");
                }
            }
            
            return codigo;
        }

        private void ListarTodosOsAlunos()
        {
            var alunos = AlunoServico.ObterTodos();

            if (alunos == null)
            {
                Console.WriteLine("Nenhum produto encontrado!!!");
                return;
            }

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                Console.WriteLine($"Código matrícula: {alunoAtual.CodigoMatricula}" +
                    $"\nNome: {alunoAtual.Nome}");
            }
        }

    }
}
