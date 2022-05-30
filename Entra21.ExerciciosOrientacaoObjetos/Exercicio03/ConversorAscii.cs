using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio03
{
    public class ConversorAscii
    {
        public char Caracter;

        public int ObterCodigoAscii()
        {
            if (Caracter.ToString() == "a")
                return 65;

            else if (Caracter.ToString() == "b")
                return 66;

            else if (Caracter.ToString() == "c")
                return 67;

            else if (Caracter.ToString() == "d")
                return 68;

            else if (Caracter.ToString() == "e")
                return 69;

            else if (Caracter.ToString() == "f")
                return 70;

            else if (Caracter.ToString() == "g")
                return 71;

            return 0;
        }
    }
}
