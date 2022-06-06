using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios06Listas
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudos = new List<string>();

            conteudos.Add("Como fazer um bolo");

            Console.WriteLine($"[1]: {conteudos[0]}");

            conteudos[conteudos.IndexOf("Como fazer um bolo")] = "Algoritmos onde vivem? Do que se alimentam";

            conteudos.Add("Variáveis");
            conteudos.Add("Mais pra frente");

            conteudos[conteudos.IndexOf("Mais pra frente")] = "IF com E";

            conteudos.Add("IF com OU");
            conteudos.Add("While");
            conteudos.Add("For");

            Console.WriteLine($"\n[01]: {conteudos[0]}" +
                $"\n[02]: {conteudos[1]}" +
                $"\n[03]: {conteudos[2]}" +
                $"\n[04]: {conteudos[3]}" +
                $"\n[05]: {conteudos[4]}" +
                $"\n[06]: {conteudos[5]}");

            conteudos.Add("Vetor");
            conteudos.Add("Vetor");

            conteudos.RemoveAt(7);
            conteudos.RemoveAt(6);

            conteudos.Add("Vetor");

            conteudos[conteudos.IndexOf("Vetor")] = "Vetor com For um amor na minha vida";


            Console.WriteLine($"\n[01]: {conteudos[0]}" +
                $"\n[02]: {conteudos[1]}" +
                $"\n[03]: {conteudos[2]}" +
                $"\n[04]: {conteudos[3]}" +
                $"\n[05]: {conteudos[4]}" +
                $"\n[06]: {conteudos[5]}" +
                $"\n[07]: {conteudos[6]}");

            conteudos.Add("Classe propriedade e metódos");


            Console.WriteLine($"\n[01]: {conteudos[0]}" +
                $"\n[02]: {conteudos[1]}" +
                $"\n[03]: {conteudos[2]}" +
                $"\n[04]: {conteudos[3]}" +
                $"\n[05]: {conteudos[4]}" +
                $"\n[06]: {conteudos[5]}" +
                $"\n[07]: {conteudos[6]}" +
                $"\n[08]: {conteudos[7]}");
        }
    }
}
