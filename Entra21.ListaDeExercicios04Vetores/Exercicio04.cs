using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios04Vetores
{
    internal class Exercicio04
    {
        public void Executar()
        {
            var table = new ConsoleTable("MATÉRIA", "MÉDIAS");
            var validar = false;
            var quantidadeDisciplinas = 0;
            while (validar == false)
            {
                try
                {
                    Console.Write("Digite a quantidade de disciplinas para cadastrar as notas: ");
                    quantidadeDisciplinas = Convert.ToInt32(Console.ReadLine());
                    if (quantidadeDisciplinas == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de disciplinas não pode ser nula");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (quantidadeDisciplinas < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A quantidade de disciplinas não pode ser negativa");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        validar = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um número inteiro");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            string[] disciplinas = new string[quantidadeDisciplinas];
            double[] notas = new double[4];

            var texto = "";

            for (int i = 0; i < disciplinas.Length; i++)
            {
                var soma = 0.0;
                var media = 0.0;

                validar = false;

                while (validar == false)
                {
                    Console.Write($"Digite a {i + 1}° disciplina: ");
                    disciplinas[i] = Console.ReadLine().Trim();
                    if (disciplinas[i].Length <= 2 || disciplinas[i].Length >= 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O nome da disciplina deve ser de no minímo 2 caracteres e no máximo 15");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        validar = true;
                    }
                }
               

                for (int j = 0; j < notas.Length; j++)
                {
                    validar = false;

                    while (validar == false)
                    {
                        try
                        {
                            Console.Write($"Digite a {j + 1}° nota da disciplida de {disciplinas[i]}: ");
                            notas[j] = Convert.ToDouble(Console.ReadLine());
                            if (notas[j] < 0 || notas[j] > 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A nota não pode ser nem menor que 0, nem maior que 10");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                validar = true;
                            }
                        }
                        catch (Exception ex) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A nota deve ser um valor númerico");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                for (int j = 0; j < notas.Length; j++)
                {
                    soma = soma + notas[j];
                }

                media = soma / notas.Length;

                texto = texto + "\n" + disciplinas[i] + " - " + media;

                Console.WriteLine("-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                notas = new double[4];

                table.AddRow(disciplinas[i], media);
            }
            table.Configure(x => x.EnableCount = false);
            table.Write(Format.Alternative);
        }
    }
}
