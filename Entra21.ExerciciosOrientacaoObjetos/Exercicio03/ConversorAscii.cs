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
            if (Caracter.ToString() == "A")
                return 65;

            else if (Caracter.ToString() == "B")
                return 66;

            else if (Caracter.ToString() == "C")
                return 67;

            else if (Caracter.ToString() == "D")
                return 68;

            else if (Caracter.ToString() == "E")
                return 69;

            else if (Caracter.ToString() == "F")
                return 70;

            else if (Caracter.ToString() == "G")
                return 71;    
            
            else if (Caracter.ToString() == "H")
                return 72;
                        
            else if (Caracter.ToString() == "I")
                return 73;
                        
            else if (Caracter.ToString() == "J")
                return 74;
                        
            else if (Caracter.ToString() == "K")
                return 75;
                        
            else if (Caracter.ToString() == "L")
                return 76;
                        
            else if (Caracter.ToString() == "M")
                return 77;
                        
            else if (Caracter.ToString() == "N")
                return 78;
                        
            else if (Caracter.ToString() == "O")
                return 79;
                        
            else if (Caracter.ToString() == "P")
                return 80;
                        
            else if (Caracter.ToString() == "Q")
                return 81;
                        
            else if (Caracter.ToString() == "R")
                return 82;
                        
            else if (Caracter.ToString() == "S")
                return 83;
                                    
            else if (Caracter.ToString() == "T")
                return 84;
                                    
            else if (Caracter.ToString() == "U")
                return 85;
                                    
            else if (Caracter.ToString() == "V")
                return 86;
                                    
            else if (Caracter.ToString() == "W")
                return 87;
                                    
            else if (Caracter.ToString() == "X")
                return 88;
                                    
            else if (Caracter.ToString() == "Y")
                return 89;
                                    
            else if (Caracter.ToString() == "Z")
                return 90;

            // Verifica letras em caixa baixa

            else if (Caracter.ToString() == "a")
                return 97;

            else if (Caracter.ToString() == "b")
                return 98;

            else if (Caracter.ToString() == "c")
                return 99;

            else if (Caracter.ToString() == "d")
                return 100;

            else if (Caracter.ToString() == "e")
                return 101;

            else if (Caracter.ToString() == "f")
                return 102;

            else if (Caracter.ToString() == "g")
                return 103;

            else if (Caracter.ToString() == "h")
                return 104;

            else if (Caracter.ToString() == "i")
                return 105;

            else if (Caracter.ToString() == "j")
                return 106;

            else if (Caracter.ToString() == "k")
                return 107;

            else if (Caracter.ToString() == "l")
                return 108;

            else if (Caracter.ToString() == "m")
                return 109;

            else if (Caracter.ToString() == "n")
                return 110;

            else if (Caracter.ToString() == "o")
                return 111;

            else if (Caracter.ToString() == "p")
                return 112;

            else if (Caracter.ToString() == "q")
                return 113;

            else if (Caracter.ToString() == "r")
                return 114;

            else if (Caracter.ToString() == "s")
                return 115;

            else if (Caracter.ToString() == "t")
                return 116;

            else if (Caracter.ToString() == "u")
                return 117;

            else if (Caracter.ToString() == "v")
                return 118;

            else if (Caracter.ToString() == "w")
                return 119;

            else if (Caracter.ToString() == "x")
                return 120;

            else if (Caracter.ToString() == "y")
                return 121;

            else if (Caracter.ToString() == "z")
                return 122;

            return 0;
        }
    }
}
