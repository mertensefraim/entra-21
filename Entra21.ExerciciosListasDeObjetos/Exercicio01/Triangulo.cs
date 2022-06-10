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
            if ((ValidarLado01() == true) || 
                (ValidarLado02() == true) || 
                (ValidarLado03() == true))
                return true;

            return false;
        }

        private bool ValidarLado01()
        {
            if (lado2 - lado3 < lado1 && lado1 < lado3 + lado3)
                return true;

            return false;
        }
        
        private bool ValidarLado02()
        {
            if (lado1 - lado3 < lado2 && lado2 < lado1 + lado3)
                return true;

            return false;
        }
        
        private bool ValidarLado03()
        {
            if (lado1 - lado2 < lado3 && lado3 < lado1 + lado2)
                return true;

            return false;
        } 
    }
}
