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

            triangulo.lado1 = lado1;
            triangulo.lado2 = lado2;
            triangulo.lado3 = lado3;

            if (triangulo.ValidarTriangulo() == false)
            {
                return false;
            }

            triangulo.Codigo = CodigoAtual;
            
            CodigoAtual++;

            triangulos.Add(triangulo);

            return true;
        }

        public bool Editar(int codigo, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloEditar = ObterPorCodigo(codigo);

            if (trianguloEditar == null)
                return false;

            trianguloEditar.lado1 = lado1;
            trianguloEditar.lado2 = lado2;
            trianguloEditar.lado3 = lado3;

            return true;
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

        public List<Triangulo> ObterTodos(int codigo)
        {
            return triangulos;
        }

    }
}
