using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio13
    {
        public void Executar()
        {
            var nomeMenorPeso = "";
            var nomeMaiorPeso = "";
            var nomeMaiorAltura = "";
            var nomeMenosAmarelo = "";
            var nomeMaisAmarelo = "";
            var nomeMenosVermelho = "";
            var nomeMaisVermelho = "";
            var nomeMaisGols = "";
            var nomeMenosGols = "";
            var maiorNome = "";
            var menorNome = "";
            var quantidadeM = 0;
            var quantidadeF = 0;
            var maiorNomeCaracteres = int.MinValue;
            var menorNomeCaracteres = int.MaxValue;
            var menosAmarelos = int.MaxValue;
            var maisAmarelos = int.MinValue;
            var menosVermelhos = int.MaxValue;
            var maisVermelhos = int.MinValue;
            var menorPeso = double.MaxValue;
            var maiorAltura = double.MinValue;
            var maiorPeso = double.MinValue;
            var menorGols = int.MaxValue;
            var maiorGols = int.MinValue;

            for (var i = 0; i < 3; i++)
            {
             
                var idade = 0;
                var cartoesVermelhos = 0;
                var golsMarcados = 0;
                var cartoesAmarelos = 0;
                var peso = 0.0;
                var altura = 0.0;
                var sexo = "";
                var nome = "";
               
                var verificador = false;
                while (verificador == false)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    if (nome.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome não pode ser menor que 3 letras");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (nome.Length > 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome não pode ser maior que 15 letras");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        verificador = true;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        if (idade < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A idade não pode ser negativa!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A idade deve ser um número inteiro!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        if (peso < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O peso não pode ser negativo!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O peso deve ser um número!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A altura não pode ser negativa!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A altura deve ser um número!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    Console.Write("Sexo: M/F ");
                    sexo = Console.ReadLine().Trim().ToLower();
                    if (sexo != "m" && sexo != "f")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O sexo deve ser 'm' para masculino e 'f' para feminino");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        verificador = true;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Quantidade de gols marcados: ");
                        golsMarcados = Convert.ToInt32(Console.ReadLine());
                        if (golsMarcados < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A quantidade de gols marcados não pode ser negativa!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de gols marcados deve ser um número inteiro!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões amarelos recebidos: ");
                        cartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                        if (cartoesAmarelos < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A quantidade de cartões amarelos não pode ser negativa!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de cartões amarelos deve ser um número inteiro!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                verificador = false;

                while (verificador == false)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões vermelhos recebidos: ");
                        cartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                        if (cartoesVermelhos < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A quantidade de cartões vermelhos não pode ser negativa!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de cartões vermelhos deve ser um número inteiro!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                if (peso <= menorPeso)
                {
                    if (peso == menorPeso)
                    {
                        nomeMenorPeso += "|" + nome;
                    }
                    else
                    {
                        nomeMenorPeso = nome;
                    }
                    menorPeso = peso;
                }

                if (peso >= maiorPeso)
                {
                    if (peso == maiorPeso)
                    {
                        nomeMaiorPeso += "|" + nome;
                    }
                    else
                    {
                        nomeMaiorPeso = nome;
                    }
                    maiorPeso = peso;
                }

                if (altura >= maiorAltura)
                {
                    if (altura == maiorAltura)
                    {
                        nomeMaiorAltura += "|" + nome;
                    }
                    else
                    {
                        nomeMaiorAltura = nome;
                    }
                    maiorAltura = altura;
                }

                if (sexo == "m")
                {
                    quantidadeM++;
                }
                else if (sexo == "f")
                {
                    quantidadeF++;
                }

                if (nome.Length >= maiorNomeCaracteres)
                {
                    if (nome.Length == maiorNomeCaracteres)
                    {
                        maiorNome += "|" + nome;
                    }
                    else
                    {
                        maiorNome = nome;
                    }
                    maiorNomeCaracteres = nome.Length;
                }

                if (nome.Length <= menorNomeCaracteres)
                {
                    if (nome.Length == menorNomeCaracteres)
                    {
                        menorNome += "|" + nome ;
                    }
                    else
                    {
                        menorNome = nome;
                    }
                    menorNomeCaracteres = nome.Length;
                }

                if (cartoesAmarelos <= menosAmarelos)
                {
                    if (cartoesAmarelos == menosAmarelos)
                    {
                        nomeMenosAmarelo += "|" + nome;
                    }
                    else
                    {
                        nomeMenosAmarelo = nome;
                    }
                    menosAmarelos = cartoesAmarelos;
                }

                if (cartoesAmarelos >= maisAmarelos)
                {
                    if (cartoesAmarelos == menosAmarelos)
                    {
                        nomeMaisAmarelo += "|" + nome;
                    }
                    else
                    {
                        nomeMaisAmarelo = nome;
                    }
                    maisAmarelos = cartoesAmarelos;
                }

                if (cartoesVermelhos <= menosVermelhos)
                {
                    if (cartoesVermelhos == menosVermelhos)
                    {
                        nomeMenosVermelho += "|" + nome;
                    }
                    else
                    {
                        nomeMenosVermelho = nome;
                    }
                    menosVermelhos = cartoesVermelhos;
                }

                if (cartoesVermelhos >= maisVermelhos)
                {
                    if (cartoesVermelhos == maisVermelhos)
                    {
                        nomeMaisVermelho += "|" + nome;
                    }
                    else
                    {
                        nomeMaisVermelho = nome;
                    }
                    maisVermelhos = cartoesVermelhos;
                }

                if (golsMarcados <= menorGols)
                {
                    if (golsMarcados == menorGols)
                    {
                        nomeMenosGols += "|" + nome;
                    }
                    else
                    {
                        nomeMenosGols = nome;
                    }
                    menorGols = golsMarcados;
                }

                if (golsMarcados >= maiorGols)
                {
                    if (golsMarcados == maiorGols)
                    {
                        nomeMaisGols += "|" + nome;
                    }
                    else
                    {
                        nomeMaisGols = nome;
                    }
                    maiorGols = golsMarcados;
                }
            }

            Console.WriteLine("Jogador com o menor peso: " + nomeMenorPeso +
                                          "\nJogador com a maior altura: " + nomeMaiorAltura +
                                          "\nJogador com o maior nome: " + maiorNome +
                                          "\nQuantidade de jogadores do sexo F: " + quantidadeF +
                                          "\nQuantidade de jogadores do sexo M: " + quantidadeM +
                                          "\nJogador com a menor quantidade de cartões amarelos recebidos: " + nomeMenosAmarelo +
                                          "\nJogador com o menor nome: " + nomeMenorPeso +
                                          "\nJogador com o maior peso: " + nomeMaiorPeso +
                                          "\nJogador com a maior quantidade de cartões vermelhos recebidos: " + nomeMaisVermelho +
                                          "\nJogador com a maior quantidade de cartões amarelos recebidos: " + nomeMaisAmarelo +
                                          "\nJogador com a menor quantidade de cartões vermelhos recebidos: " + nomeMenosVermelho +
                                          "\nJogador com a menor quantidade de gols: " + nomeMenosGols + 
                                          "\nJogador com a maior quantidade de gols: " + nomeMaisGols);
        }
    }
}
