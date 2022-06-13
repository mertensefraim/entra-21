using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> Alunos = new List<Aluno>();
        private int Codigo = 1;
        public void Adicionar(string nome, int idade, string materiaFavorita, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            aluno.CodigoMatricula = Codigo;

            Codigo++;

            Alunos.Add(aluno);
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            var alunoEditar = ObterPorCodigo(codigoMatricula);

            if (alunoEditar == null)
                return false;

            alunoEditar.Nome = nome;
            alunoEditar.Idade = idade;
            alunoEditar.MateriaFavorita = materiaFavorita;

            return true;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            var alunoEditar = ObterPorCodigo(codigoMatricula);

            if (alunoEditar == null)
                return false;

            alunoEditar.Nota1 = nota1;
            alunoEditar.Nota2 = nota2;
            alunoEditar.Nota3 = nota3;

            return true;
        }

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
                var alunoAtual = Alunos[i];

                if (alunoAtual.Nome == nome)
                {
                    Alunos.Remove(alunoAtual);
                    return true;
                }
            }

            return false;
        }

        public Aluno ObterPorCodigo(int codigoMatricula)
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
                var alunoAtual = Alunos[i];

                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    return alunoAtual;
                }
            }

            return null;
        }

        public List<string> ObterNomes()
        {
            List<string> nomes = new List<string>();

            if (Alunos == null)
            {
                return null;
            }

            for (int i = 0; i < Alunos.Count; i++)
            {
                var alunoAtual = Alunos[i];

                nomes.Add(alunoAtual.Nome);
            }

            return nomes;
        }

        public List<double> ObterMedias()
        {
            List<double> notas = new List<double>();

            if (Alunos == null)
            {
                return null;
            }

            for (int i = 0; i < Alunos.Count; i++)
            {
                var alunoAtual = Alunos[i];

                notas.Add(alunoAtual.CalcularMedia());
            }

            return notas;
        }

        public List<string> ObterAprovados()
        {
            List<string> aprovados = new List<string>();

            if (Alunos == null)
            {
                return null;
            }

            for (int i = 0; i < Alunos.Count; i++)
            {
                var AlunoAtual = Alunos[i];
                
                if (AlunoAtual.ObterStatus() == AlunoStatus.Aprovado)
                    aprovados.Add(AlunoAtual.Nome);
            }

            return aprovados;
        }

        public List<string> ObterReprovados()
        {
            List<string> reprovados = new List<string>();

            if (Alunos == null)
            {
                return null;
            }

            for (int i = 0; i < Alunos.Count; i++)
            {
                var AlunoAtual = Alunos[i];
                
                if (AlunoAtual.ObterStatus() == AlunoStatus.Reprovado)
                    reprovados.Add(AlunoAtual.Nome);
            }

            return reprovados;
        }
        
        public List<string> ObterEmExame()
        {
            List<string> emExame = new List<string>();

            if (Alunos == null)
            {
                return null;
            }

            for (int i = 0; i < Alunos.Count; i++)
            {
                var AlunoAtual = Alunos[i];
                
                if (AlunoAtual.ObterStatus() == AlunoStatus.EmExame)
                    emExame.Add(AlunoAtual.Nome);
            }

            return emExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var alunoAtual = ObterPorCodigo(codigoMatricula);

            return alunoAtual.CalcularMedia();
        }
        
        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            var alunoAtual = ObterPorCodigo(codigoMatricula);

            return alunoAtual.ObterStatus();
        }

        public double ObterMediaIdades()
        {
            var somaIdades = 0.0;

            for (int i = 0; i < Alunos.Count; i++)
            {
                somaIdades += Alunos[i].Idade;
            }

            var mediaIdades = somaIdades / Alunos.Count;

            return mediaIdades;
        }
    }
}
