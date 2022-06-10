using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio01
{
    internal class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            if ((lado2 - lado3 < lado1 && lado1 < lado2 + lado3) || lado1 + lado3 > lado1 || lado3 + lado1 > lado2)
                return true;

            return false;
        }
    }
}
