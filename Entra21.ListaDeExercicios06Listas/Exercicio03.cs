using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios06Listas
{
    public class Exercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();

            Console.Write("Nota 01: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            
            Console.Write("Nota 02: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            
            Console.Write("Nota 03: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            var media = (notas[0] + notas[1] + notas[2]) / notas.Count;

            if (media < 7.0)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Aprovado");
        }
    }
}
