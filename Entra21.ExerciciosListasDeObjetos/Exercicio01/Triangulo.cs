using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasDeObjetos.Exercicio01
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public TrianguloTipo TipoTriangulo;
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
            if (Lado2 - Lado3 < Lado1 && Lado1 < Lado3 + Lado3)
                return true;

            return false;
        }
        
        private bool ValidarLado02()
        {
            if (Lado1 - Lado3 < Lado2 && Lado2 < Lado1 + Lado3)
                return true;

            return false;
        }
        
        private bool ValidarLado03()
        {
            if (Lado1 - Lado2 < Lado3 && Lado3 < Lado1 + Lado2)
                return true;

            return false;
        }
        
        public bool EhIsoceles(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                    return false;

                return true;
            }

            return false;
        } 
        
        public bool EhEscaleno(int lado1, int lado2, int lado3)
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                return true;

            return false;
        }

        public bool EhEquilatero(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                return true;

            return false;
        }
    }
}
