using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03___While
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double pesoUsuario = 0;
            int quantidadePessoas = 0;
            while (pesoUsuario >= 0 && pesoUsuario <= 300)
            {
                Console.Write("Digite o seu peso: ");
                pesoUsuario = Convert.ToDouble(Console.ReadLine());
                quantidadePessoas = quantidadePessoas + 1;
            }
            Console.WriteLine("A quantidade de pessoas que colocaram seu peso foi de " + quantidadePessoas);

        }
    }
}
