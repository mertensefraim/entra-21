using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios06Listas
{
    class Exercicio01
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evollution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna verde");

            Console.WriteLine($"\n[01]: {filmes[0]}" +
                $"\n[02]: {filmes[1]}" +
                $"\n[03]: {filmes[2]}");

            filmes.Add("");

            filmes[0] = "Dragon Ball Super: Broly";

            filmes.Remove("Lanterna verde");

            if (filmes.Contains("Lanterna verde"))
                Console.WriteLine("\nExiste o filme Lanterna verde");
            else
                Console.WriteLine("\nNão existe o filme Lanterna verde");

            filmes.Add("Quarteto Fantástico");

            Console.WriteLine($"\n[01]: {filmes[0]}" +
                $"\n[02]: {filmes[1]}" +
                $"\n[03]: {filmes[2]}");

            filmes[filmes.IndexOf("Titanic")] = "Titanic 2";

            Console.WriteLine($"\n[01]: {filmes[0]}" +
                $"\n[02]: {filmes[1]}" +
                $"\n[03]: {filmes[2]}");

            if (filmes.Contains("Lagoa azul"))
                Console.WriteLine("\nExiste o filme Lagoa Azul");
            else
                Console.WriteLine("\nNão existe o filme Lagoa azul");
        }
    }
}
