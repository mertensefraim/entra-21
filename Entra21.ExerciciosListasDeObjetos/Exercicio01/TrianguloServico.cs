using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int CodigoAtual = 1;

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                if (codigo == trianguloAtual.Codigo)
                    return trianguloAtual;
            }

            return null;
        }

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            if (triangulo.ValidarTriangulo() == false)
            {
                return false;
            }

            if (triangulo.EhEquilatero(lado1, lado2, lado3) == true)
                triangulo.TipoTriangulo = TrianguloTipo.Equilatero;
            else if (triangulo.EhEscaleno(lado1, lado2, lado3) == true)
                triangulo.TipoTriangulo = TrianguloTipo.Escaleno;
            else if (triangulo.EhIsoceles(lado1, lado2, lado3) == true)
                triangulo.TipoTriangulo = TrianguloTipo.Isoceles;

            triangulo.Codigo = CodigoAtual;
            
            CodigoAtual++;

            triangulos.Add(triangulo);

            return true;
        }

        public int Editar(int codigo, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloEditar = ObterPorCodigo(codigo);
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            if (trianguloEditar == null)
                return 0;

            else if (triangulo.ValidarTriangulo() == true)
            {
                trianguloEditar = triangulo;
                return 2;
            }

            return 1;
        }

        public bool Apagar(int codigo)
        {
            Triangulo trianguloApagar = ObterPorCodigo(codigo);

            if (trianguloApagar.Codigo == codigo)
            {
                triangulos.Remove(trianguloApagar);
                return true;
            }
            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }
    }
}
