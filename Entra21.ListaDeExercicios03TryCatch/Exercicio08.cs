using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios03TryCatch
{
    internal class Exercicio08
    {
        public void Executar()
        {
            var numeroUsuario = 0.0;
            var verificador = false;
            while(verificador == false)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    numeroUsuario = Convert.ToDouble(Console.ReadLine());
                    verificador = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor deve ser um número");
                }
            }

            for(var i = 0; i <= 1000; i++)
            {
                Console.WriteLine(numeroUsuario + " X " + i + " = " + (numeroUsuario * i));
            }
        }    
    }
}
