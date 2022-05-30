using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio03
{
    public class ExemploConversorAscii
    {
        public void Executar()
        {
            var conversor = new ConversorAscii();

            conversor.Caracter = 'a';

            if (conversor.ObterCodigoAscii() == 0)
            {
                Console.WriteLine("Valor não possuí código ASCII válido");
            }
            else
            {
                Console.WriteLine(conversor.ObterCodigoAscii());
            }
        }
    }
}
