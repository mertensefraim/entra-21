using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio17
    {
        //public void Executar()
        //{
        //    int valorUm = 23, valorDois = 59, valorTres = 60;
        //    string valorUmString = "23", valorDoisString = "59", valorTresString = "60";
        //    while (valorUm != -1)
        //    {
        //        while(valorTres != 00)
        //        {
        //            valorTres = valorTres - 1;
        //            if (valorTres >= 10)
        //            {
        //                valorTresString = Convert.ToString(valorTres);
        //                Console.WriteLine(valorUmString + ":" + valorDoisString + ":" + valorTresString);
        //            }
        //            else
        //            {
        //                valorTresString = Convert.ToString(valorTres);
        //                valorTresString = "0" + valorTres;
        //                Console.WriteLine(valorUmString + ":" + valorDoisString + ":" + valorTresString);
        //            }
        //        }
        //        if (valorDois != 0)
        //        {
        //            valorDois = valorDois - 1;
        //            valorDoisString = Convert.ToString(valorDois);
        //            if(valorDois < 10)
        //            {
        //                valorDoisString = Convert.ToString(valorDois);
        //                valorDoisString = "0" + valorDois;
        //            }
        //        }
        //        else
        //        {
        //            valorDois = 59;
        //            valorDoisString = Convert.ToString(valorDois);
        //            valorUm = valorUm - 1;
        //            if(valorUm < 10)
        //            {
        //                valorUmString = Convert.ToString(valorUm);
        //                valorUmString = "0" + valorUm;
        //            }
        //            else
        //            {
        //                valorUmString = Convert.ToString(valorUm);
        //            }
        //        }
        //        valorTres = 60;
        //    }
        //}


        //public void Executar()
        //{
        //    int hora = 23;
            
        //    while (hora >= 0)
        //    {
        //        string horaFormatada = hora.ToString();
        //        if (hora < 10)
        //        {
        //            horaFormatada = "0" + hora.ToString();
        //        }
        //        int minuto = 59;
        //        while (minuto >= 0)
        //        {
        //            string minutoFormatado = minuto.ToString();
        //            if (minuto < 10)
        //            {
        //               minutoFormatado = "0" + minuto.ToString();
        //            }
        //            int segundo = 59;
        //            while (segundo >= 0)
        //            {
        //                string segundoFormatado = segundo.ToString();
        //                if (segundo < 10)
        //                {
        //                    segundoFormatado = "0" + segundo.ToString();
        //                }
        //                Console.WriteLine(
        //                    horaFormatada + ":" +
        //                    minutoFormatado + ":" +
        //                    segundoFormatado);
        //                segundo = segundo - 1;
        //            }
        //            minuto = minuto - 1;
        //        }
        //        hora = hora - 1;
        //    }
        //}

        //public void Executar()
        //{
        //    int hora = 23;
        //    while (hora >= 0)
        //    {
        //        string horaFormatada = hora.ToString();
        //        if(hora < 10)
        //        {
        //            horaFormatada = "0" + horaFormatada; 
        //        }
        //        int minuto = 59;
        //        while(minuto >= 0)
        //        {
        //            string minutoFormatado = minuto.ToString();
        //            if (minuto < 10)
        //            {
        //                minutoFormatado = "0" + minutoFormatado;
        //            }
        //            int segundo = 59;
        //            while(segundo >= 0)
        //            {
        //                string segundoFormatado = segundo.ToString();
        //                if (segundo < 10)
        //                {
        //                    segundoFormatado = "0" + segundoFormatado;
        //                }
        //                Console.WriteLine(horaFormatada + ":" +
        //                                  minutoFormatado + ":" +
        //                                  segundoFormatado);
        //                segundo = segundo - 1;
        //            }
        //            minuto = minuto - 1;
        //        }
        //        hora = hora - 1;
        //    }
        //}

        public void Executar()
        {
            int hora = 23;
            while (hora >= 0)
            {
                string horaFormatada = hora.ToString();
                if (hora < 10)
                {
                    horaFormatada = "0" + horaFormatada;
                }
                int minuto = 59;
                while(minuto >= 0)
                {
                    string minutoFormatado = minuto.ToString();
                    if (minuto < 10)
                    {
                        minutoFormatado = "0" + minutoFormatado;
                    }
                    int segundo = 59;
                    while(segundo >= 0)
                    {
                        string segundoFormatado = segundo.ToString();
                        if (segundo < 10)
                        {
                            segundoFormatado = "0" + segundoFormatado;
                        }
                        Console.WriteLine(horaFormatada + ":" +
                                          minutoFormatado + ":" +
                                          segundoFormatado);
                        segundo = segundo - 1;
                    }
                    minuto = minuto - 1;
                }
                hora = hora - 1;
            }
        }
    }
}
