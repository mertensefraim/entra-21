using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio02
{
    public class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double CalcularMedia()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3;
            return media;
        }

        public AlunoStatus ObterStatus()
        {
            if (CalcularMedia() < 5.0)
                return AlunoStatus.Reprovado;
            
            else if (CalcularMedia() >= 7.0)
                return AlunoStatus.Aprovado;

            else
                return AlunoStatus.EmExame;
        }
    }
}
