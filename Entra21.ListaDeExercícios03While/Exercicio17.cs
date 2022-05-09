using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int valorUm = 23, valorDois = 59, valorTres = 60;
            string valorUmString = "23", valorDoisString = "59", valorTresString = "60";
            while (valorUm != -1)
            {
                while(valorTres != 00)
                {
                    valorTres = valorTres - 1;
                    if (valorTres >= 10)
                    {
                        valorTresString = Convert.ToString(valorTres);
                        Console.WriteLine(valorUmString + ":" + valorDoisString + ":" + valorTresString);
                    }
                    else
                    {
                        valorTresString = Convert.ToString(valorTres);
                        valorTresString = "0" + valorTres;
                        Console.WriteLine(valorUmString + ":" + valorDoisString + ":" + valorTresString);
                    }
                }
                if (valorDois != 0)
                {
                    valorDois = valorDois - 1;
                    valorDoisString = Convert.ToString(valorDois);
                    if(valorDois < 10)
                    {
                        valorDoisString = Convert.ToString(valorDois);
                        valorDoisString = "0" + valorDois;
                    }
                }
                else
                {
                    valorDois = 59;
                    valorDoisString = Convert.ToString(valorDois);
                    valorUm = valorUm - 1;
                    if(valorUm < 10)
                    {
                        valorUmString = Convert.ToString(valorUm);
                        valorUmString = "0" + valorUm;
                    }
                    else
                    {
                        valorUmString = Convert.ToString(valorUm);
                    }
                }
                valorTres = 60;
            }
        }
    }
}
