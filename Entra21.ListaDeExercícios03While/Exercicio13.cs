using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int indice = 0;

            int quantidadeHomens = 0, quantidadeMulheres = 0, quantidadeCartoesVermelhosMenor = int.MaxValue, quantidadeCartoesAmarelosMenor = int.MaxValue,
                quantidadeCartoesVermelhosMaior = int.MinValue, quantidadeCartoesAmarelosMaior = int.MinValue, menorNome = int.MaxValue;
            double maiorAltura = double.MinValue, menorPeso = double.MaxValue, maiorPeso = double.MinValue;
            string maiorQuantidadeCartoesVermelhosJogador = "", menorQuantidadeCartoesVermelhosJogador = "", maiorQuantidadeCartoesAmarelosJogador = "", menorQuantidadeCartoesAmarelosJogador = "",
                   menorPesoJogador = "", maiorPesoJogador = "", maiorAlturaJogador = "", maiorNomeJogador = "", menorNomeJogador = "";
            while (indice < 3)
            {
                Console.Write("Nome: ");
                string nomeJogador = Console.ReadLine();

                Console.Write("Idade: ");
                int idadeJogador = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Peso: ");
                double pesoJogador = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Sexo: M/F ");
                string sexoJogador = Console.ReadLine().ToLower().Trim();
                
                Console.Write("Altura: ");
                double alturaJogador = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Quantidade de gols marcados: ");
                int quantidadeGols = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Quantidade de cartões vermelhos recebidos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                if (pesoJogador <= menorPeso)
                {
                    if (pesoJogador == menorPeso)
                    {
                        menorPesoJogador = pesoJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        menorPesoJogador = nomeJogador;
                    }
                    menorPeso = pesoJogador;
                }
                if (pesoJogador >= maiorPeso)
                {
                    if (pesoJogador == maiorPeso)
                    {
                        maiorPesoJogador = maiorPesoJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        maiorPesoJogador = nomeJogador;
                    }
                    maiorPeso = pesoJogador;
                }
                if (alturaJogador >= maiorAltura)
                {
                    if (alturaJogador == maiorAltura)
                    {
                        maiorAlturaJogador = maiorAlturaJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        maiorAlturaJogador = nomeJogador;
                    }
                    maiorAltura = alturaJogador;
                }
                if (nomeJogador.Length >= maiorNomeJogador.Length)
                {
                    if (nomeJogador.Length == maiorNomeJogador.Length)
                    {
                        maiorNomeJogador = maiorNomeJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        maiorNomeJogador = nomeJogador;
                    }
                }
                if (nomeJogador.Length <= menorNome)
                {
                    if (nomeJogador.Length == menorNome)
                    {
                        menorNomeJogador = menorNomeJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        menorNomeJogador = nomeJogador;
                    }
                    menorNome = nomeJogador.Length;
                }
                if (sexoJogador == "f")
                {
                    quantidadeMulheres = quantidadeMulheres + 1;
                }
                else if (sexoJogador == "m")
                {
                    quantidadeHomens = quantidadeHomens + 1;
                }

                if (quantidadeCartoesAmarelos <= quantidadeCartoesAmarelosMenor)
                {
                    if (quantidadeCartoesAmarelos == quantidadeCartoesAmarelosMenor)
                    {
                        menorQuantidadeCartoesAmarelosJogador = menorQuantidadeCartoesAmarelosJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        menorQuantidadeCartoesAmarelosJogador = nomeJogador;
                    }
                    quantidadeCartoesAmarelosMenor = quantidadeCartoesAmarelos;
                }

                if (quantidadeCartoesVermelhos >= quantidadeCartoesVermelhosMaior)
                {
                    if (quantidadeCartoesVermelhos == quantidadeCartoesVermelhosMaior)
                    {
                        maiorQuantidadeCartoesVermelhosJogador = maiorQuantidadeCartoesVermelhosJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        maiorQuantidadeCartoesVermelhosJogador = nomeJogador;
                    }
                    quantidadeCartoesVermelhosMaior = quantidadeCartoesVermelhos;
                }
                if (quantidadeCartoesAmarelos >= quantidadeCartoesAmarelosMaior)
                {
                    if (quantidadeCartoesAmarelos == quantidadeCartoesAmarelosMaior)
                    {
                        maiorQuantidadeCartoesAmarelosJogador = maiorQuantidadeCartoesAmarelosJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        maiorQuantidadeCartoesAmarelosJogador = nomeJogador;
                    }
                    quantidadeCartoesAmarelosMaior = quantidadeCartoesAmarelos;
                }
                if (quantidadeCartoesVermelhos <= quantidadeCartoesVermelhosMenor)
                {
                    if (quantidadeCartoesVermelhos == quantidadeCartoesVermelhosMenor)
                    {
                        menorQuantidadeCartoesVermelhosJogador = menorQuantidadeCartoesVermelhosJogador + ", " + nomeJogador;
                    }
                    else
                    {
                        menorQuantidadeCartoesVermelhosJogador = nomeJogador;
                    }
                    quantidadeCartoesVermelhosMenor = quantidadeCartoesVermelhos;
                }
                indice = indice + 1;
            }
            Console.WriteLine("Jogador com o menor peso: " + menorPesoJogador +
                              "\nJogador com a maior altura: " + maiorAlturaJogador +
                              "\nJogador com o maior nome: " + maiorNomeJogador +
                              "\nQuantidade de jogadores do sexo F: " + quantidadeMulheres +
                              "\nQuantidade de jogadores do sexo M: " + quantidadeHomens +
                              "\nJogador com a menor quantidade de cartões amarelos recebidos: " + menorQuantidadeCartoesAmarelosJogador +
                              "\nJogador com o menor nome: " + menorNomeJogador +
                              "\nJogador com o maior peso: " + maiorPesoJogador +
                              "\nJogador com a maior quantidade de cartões vermelhos recebidos: " + maiorQuantidadeCartoesVermelhosJogador +
                              "\nJogador com a maior quantidade de cartões amarelos recebidos: " + maiorQuantidadeCartoesAmarelosJogador +
                              "\nJogador com a menor quantidade de cartões vermelhos recebidos: " + menorQuantidadeCartoesVermelhosJogador);
        }
    }
}
