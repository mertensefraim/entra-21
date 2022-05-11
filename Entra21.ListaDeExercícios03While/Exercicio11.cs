using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int escolhaDesejada = 0;

            Console.Write("Digite um número: ");
            double numeroUsuarioUm = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite outro número: ");
            double numeroUsuarioDois = Convert.ToDouble(Console.ReadLine());
            
            while (escolhaDesejada != 6)
            {
                Console.WriteLine(@"-------------------------MENU-------------------------
|1 --------------------------- Somar                 |
|2 --------------------------- Subtrair              |
|3 --------------------------- Multiplicar           |
|4 --------------------------- Dividir               |
|5 --------------------------- Digitar novos números |
|6 --------------------------- Sair                  |
------------------------------------------------------");

                Console.Write("Digite o valor referente a operação desejada: ");
                escolhaDesejada = Convert.ToInt32(Console.ReadLine());

                if(escolhaDesejada == 1)
                {
                    Console.WriteLine(numeroUsuarioUm + " + " + numeroUsuarioDois + " = " + (numeroUsuarioUm + numeroUsuarioDois));
                }
                else if (escolhaDesejada == 2)
                {
                    Console.WriteLine(numeroUsuarioUm + " - " + numeroUsuarioDois + " = " + (numeroUsuarioUm - numeroUsuarioDois));
                }
                else if (escolhaDesejada == 3)
                {
                    Console.WriteLine(numeroUsuarioUm + " x " + numeroUsuarioDois + " = " + (numeroUsuarioUm * numeroUsuarioDois));
                }
                else if (escolhaDesejada == 4)
                {
                    Console.WriteLine(numeroUsuarioUm + " / " + numeroUsuarioDois + " = " + (numeroUsuarioUm / numeroUsuarioDois));
                }
                else if (escolhaDesejada == 4)
                {
                    Console.WriteLine(numeroUsuarioUm + " / " + numeroUsuarioDois + " = " + (numeroUsuarioUm / numeroUsuarioDois));
                }
                //else if (escolhaDesejada == 5)
                //{
                //    Console.Write("Digite um número: ");
                //    numeroUsuarioUm = Convert.ToDouble(Console.ReadLine());
                //    Console.Write("Digite outro número: ");
                //    numeroUsuarioDois = Convert.ToDouble(Console.ReadLine());
                //}
                else if (escolhaDesejada == 6)
                {
                    Console.WriteLine("Obrigado por usar nosso programa ( :");
                }
                else
                {
                    Console.WriteLine("Esse opção não existe, tente novamente!!!");
                }
            }
        }

    }
}
