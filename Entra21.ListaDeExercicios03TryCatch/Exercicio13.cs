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
            for (var i = 0; i < 3; i++)
            {
                var idade = 0;
                var quantidadeGols = 0;
                var cartoesAmarelos = 0;
                var cartoesVermelhos = 0;
                var peso = 0.0;
                var menorPeso = 0.0;
                var maiorPeso = 0.0;
                var altura = 0.0;
                var menorAltura = 0.0;
                var maiorAltura = 0.0;
                var sexo = "";
                var nome = "";
                var verificador = false;
                while (verificador == false)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    if (nome.Length < 3)
                    {
                        Console.WriteLine("O nome não pode ser menor que 3 letras");
                    }
                    else if (nome.Length > 15)
                    {
                        Console.WriteLine("O nome não pode ser maior que 15 letras");
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
                            Console.WriteLine("A idade não pode ser negativa!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A idade deve ser um número inteiro!");
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
                            Console.WriteLine("O peso não pode ser negativo!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O peso deve ser um número!");
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
                            Console.WriteLine("A altura não pode ser negativa!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A altura deve ser um número!");
                    }
                }

                while (verificador == false)
                {
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine().Trim().ToLower();
                    if (sexo != "m" || sexo != "f")
                    {
                        Console.WriteLine("O sexo deve ser 'm' para masculino e 'f' para feminino");
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
                            Console.WriteLine("A quantidade de gols marcados não pode ser negativa!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A quantidade de gols marcados deve ser um número inteiro!");
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
                            Console.WriteLine("A quantidade de cartões amarelos não pode ser negativa!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A quantidade de cartões amarelos deve ser um número inteiro!");
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
                            Console.WriteLine("A quantidade de cartões vermelhos não pode ser negativa!");
                        }
                        else
                        {
                            verificador = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A quantidade de cartões vermelhos deve ser um número inteiro!");
                    }
                }

            }
        }
    }
}
