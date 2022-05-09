using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercício13
    {
        public void Executar()
        {
            int indice = 0;

            int quantidadeHomens = 0, quantidadeMulheres = 0, quantidadeCartoesVermelhosMenor = int.MinValue, quantidadeCartoesAmarelosMenor = int.MinValue,
                quantidadeCartoesVermelhosMaior = int.MaxValue, quantidadeCartoesAmarelosMaior = int.MaxValue, maiorNome = int.MinValue, menorNome = int.MaxValue;
            double maiorAltura = double.MinValue, menorPeso = double.MaxValue, maiorPeso = double.MinValue;
            string maiorQuantidadeCartoesVermelhosJogador = "", menorQuantidadeCartoesVermelhosJogador = "", maiorQuantidadeCartoesAmarelosJogador = "", menorQuantidadeCartoesAmarelosJogador = "", 
                   menorPesoJogador = "", maiorPesoJogador = "", maiorAlturaJogador = "", maiorNomeJogador = "", menorNomeJogador = "";
            while (indice < 22)
            {
                Console.Write("Nome: ");
                string nomeJogador = Console.ReadLine();
                Console.Write("Idade: ");
                int idadeJogador =  Convert.ToInt32(Console.ReadLine());
                Console.Write("Peso");
                double pesoJogador = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sexo: M/F");
                string sexoJogador = Console.ReadLine().ToLower().Trim();
                Console.Write("Altura: ");
                double alturaJogador = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de gols marcados: ");
                int quantidadeGols = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões vermelhos recebidos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                if(pesoJogador < menorPeso)
                {
                    menorPesoJogador = nomeJogador;
                    menorPeso = pesoJogador;
                }
                if(pesoJogador > maiorPeso)
                {
                    maiorPesoJogador = nomeJogador;
                    maiorPeso = pesoJogador;
                }
                if(alturaJogador > maiorAltura)
                {
                    maiorAlturaJogador = nomeJogador;
                    maiorAltura = alturaJogador;
                }
                if(nomeJogador.Length > maiorNome)
                {
                    maiorNomeJogador = nomeJogador;
                    maiorNome = nomeJogador.Length;
                }
                if (nomeJogador.Length < menorNome)
                {
                    menorNomeJogador = nomeJogador;
                    menorNome = nomeJogador.Length;
                }
                if (sexoJogador == "f")
                {
                    quantidadeMulheres = quantidadeMulheres + 1;
                }
                if (sexoJogador == "m")
                {
                    quantidadeHomens = quantidadeHomens + 1;
                }
                if(quantidadeCartoesAmarelos < quantidadeCartoesAmarelosMenor)
                {
                    menorQuantidadeCartoesAmarelosJogador = nomeJogador;
                    quantidadeCartoesAmarelosMenor = quantidadeCartoesAmarelos;
                }
                if(quantidadeCartoesVermelhos > quantidadeCartoesVermelhosMaior)
                {
                    maiorQuantidadeCartoesVermelhosJogador = nomeJogador;
                    quantidadeCartoesVermelhosMaior = quantidadeCartoesVermelhos;
                }
                if(quantidadeCartoesAmarelos > quantidadeCartoesAmarelosMaior)
                {
                    maiorQuantidadeCartoesAmarelosJogador = nomeJogador;
                    quantidadeCartoesAmarelosMaior = quantidadeCartoesAmarelos;
                }
                if(quantidadeCartoesVermelhos < quantidadeCartoesVermelhosMenor)
                {
                    menorQuantidadeCartoesVermelhosJogador = nomeJogador;
                    quantidadeCartoesVermelhosMenor = quantidadeCartoesVermelhos;
                }
                indice = indice + 1;
            }
            Console.WriteLine("")
        }
    }
}
