using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloServico TrianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            var codigo = 0;
            
            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                    ListarTodos();

                else if (codigo == 2)
                    Adicionar();

                else if (codigo == 3)
                    Editar();

                else if (codigo == 4)
                    Apagar();

                else if (codigo == 5)
                    ListarProduto();

                Console.ReadKey();
            }
        }

        private void ListarProduto()
        {
            ListarTodos();

            Console.Write("Digite o código do triângulo que deseja visualizar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var obter = TrianguloServico.ObterPorCodigo(codigo);

            Console.WriteLine($"Tipo: {ObterTipoTriangulo()}" +
                $"\nLado 01: {obter.lado1}" +
                $"\nLado 02: {obter.lado2}" +
                $"\nLado 03: {obter.lado3}" +
                $"\nCódigo: {codigo}\n");
        }

        private void Apagar()
        {
            ListarTodos();

            Console.Write("Digite o código do triângulo que deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var apagar = TrianguloServico.Apagar(codigo);

            Console.WriteLine(apagar == false
                ? "Código do triângulo inválido"
                : "Produto apagado com sucesso");
        }

        private void Editar()
        {
            ListarTodos();

            Console.Write("Digite o código do triângulo que deseja editar: ");
            var codigoEditar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 01: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 02: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 03: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var editar = TrianguloServico.Editar(codigoEditar, lado1, lado2, lado3);

            if (editar == 0)
                Console.WriteLine("Não foi possível editar pois o código é inexiste ou os valores não podem formar um triângulo");

            else if (editar == 0)
                Console.WriteLine("Os valores não podem formar um triângulo");

            else
                Console.WriteLine("Produto alterado com sucesso");
        }

        private void Adicionar()
        {
            Console.Write("Lado 01: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 02: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 03: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var adicionar = TrianguloServico.Adicionar(lado1, lado2, lado3);

            while (adicionar == false)
            {
                Console.WriteLine("Os valores não podem formar um triângulo, tente novamente");

                Console.Write("Lado 01: ");
                lado1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lado 02: ");
                lado2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lado 03: ");
                lado3 = Convert.ToInt32(Console.ReadLine());

                adicionar = TrianguloServico.Adicionar(lado1, lado2, lado3);
            }
        }

        private void ListarTodos()
        {
            var triangulos = TrianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Não há nenhum triângulo cadastrado!!!");
                return;
            }
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                Console.WriteLine($"Tipo: {ObterTipoTriangulo()}" +
                    $"\nCódigo: {trianguloAtual.Codigo}\n");
            }

        }

        public int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"MENU: 
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - Sair");

            var codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            var verificador = false;
            var codigo = 0;
            while (verificador == false)
            {
                try
                {
                    Console.Write("Digite o código desejado: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    if (codigo <= 0 || codigo > 6)
                        Console.WriteLine("O código deve ser maior que 0 e menor que 7");
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

        private TrianguloTipo ObterTipoTriangulo()
        {
            Triangulo triangulo = new Triangulo();

            if (triangulo.EhIsoceles() == true)
                return TrianguloTipo.Isoceles;

            else if (triangulo.EhEquilatero() == true)
                return TrianguloTipo.Equilatero;

            return TrianguloTipo.Escaleno;
        }
    }
}
