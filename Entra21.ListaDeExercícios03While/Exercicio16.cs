using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercícios03While
{
    internal class Exercicio16
    {
        public void Executar()
        {
            Console.Write("Digite uma frase: ");
            string fraseUsuario = Console.ReadLine().ToLower().Trim();
            int indice = 0, quantidadeCaracteres = fraseUsuario.Length, caracteresA = 0, caracteresB = 0, caracteresC = 0, caracteresÇ = 0, caracteresD = 0, caracteresE = 0, caracteresF = 0,
                caracteresG = 0, caracteresH = 0, caracteresI = 0, caracteresJ = 0, caracteresK = 0, caracteresL = 0, caracteresM = 0, caracteresN = 0, caracteresO = 0,
                caracteresP = 0, caracteresQ = 0, caracteresR = 0, caracteresS = 0, caracteresT = 0, caracteresU = 0, caracteresV = 0, caracteresW = 0, caracteresX = 0, 
                caracteresY = 0, caracteresZ = 0;
            while (indice < quantidadeCaracteres)
            {
                string caracterUsuario = fraseUsuario.Substring(indice, 1);
                if (caracterUsuario == "a")
                {
                    caracteresA = caracteresA + 1;
                }
                else if(caracterUsuario == "b")
                {
                    caracteresB = caracteresB + 1;
                }
                else if (caracterUsuario == "c")
                {
                    caracteresC = caracteresC + 1;
                }
                else if (caracterUsuario == "ç")
                {
                    caracteresÇ = caracteresÇ + 1;
                }
                else if (caracterUsuario == "d")
                {
                    caracteresD = caracteresD + 1;
                }
                else if (caracterUsuario == "e")
                {
                    caracteresE = caracteresE + 1;
                }
                else if (caracterUsuario == "f")
                {
                    caracteresF = caracteresF + 1;
                }
                else if (caracterUsuario == "g")
                {
                    caracteresG = caracteresG + 1;
                }
                else if (caracterUsuario == "h")
                {
                    caracteresH = caracteresH + 1;
                }
                else if (caracterUsuario == "i")
                {
                    caracteresI = caracteresI + 1;
                }
                else if (caracterUsuario == "j")
                {
                    caracteresJ = caracteresJ + 1;
                }
                else if (caracterUsuario == "k")
                {
                    caracteresK = caracteresK + 1;
                }
                else if (caracterUsuario == "l")
                {
                    caracteresL = caracteresL + 1;
                }
                else if (caracterUsuario == "m")
                {
                    caracteresM = caracteresM + 1;
                }
                else if (caracterUsuario == "n")
                {
                    caracteresN = caracteresN + 1;
                }
                else if (caracterUsuario == "o")
                {
                    caracteresO = caracteresO + 1;
                }
                else if (caracterUsuario == "p")
                {
                    caracteresP = caracteresP + 1;
                }
                else if (caracterUsuario == "q")
                {
                    caracteresQ = caracteresQ + 1;
                }
                else if (caracterUsuario == "r")
                {
                    caracteresR = caracteresR + 1;
                }
                else if (caracterUsuario == "s")
                {
                    caracteresS = caracteresS + 1;
                }
                else if (caracterUsuario == "t")
                {
                    caracteresT = caracteresT + 1;
                }
                else if (caracterUsuario == "u")
                {
                    caracteresU = caracteresU + 1;
                }
                else if (caracterUsuario == "v")
                {
                    caracteresV = caracteresV + 1;
                }
                else if (caracterUsuario == "w")
                {
                    caracteresW = caracteresW + 1;
                }
                else if (caracterUsuario == "x")
                {
                    caracteresX = caracteresX + 1;
                }
                else if (caracterUsuario == "y")
                {
                    caracteresY = caracteresY + 1;
                }
                else if (caracterUsuario == "z")
                {
                    caracteresZ = caracteresZ + 1;
                }
                indice = indice + 1;
            }
            Console.WriteLine("a = " + caracteresA +
                  "\nb = " + caracteresB +
                  "\nc = " + caracteresC +
                  "\nç = " + caracteresÇ +
                  "\nd = " + caracteresD +
                  "\ne = " + caracteresE +
                  "\nf = " + caracteresF +
                  "\ng = " + caracteresG +
                  "\nh = " + caracteresH +
                  "\ni = " + caracteresI +
                  "\nj = " + caracteresJ +
                  "\nk = " + caracteresK +
                  "\nl = " + caracteresL +
                  "\nm = " + caracteresM +
                  "\nn = " + caracteresN +
                  "\no = " + caracteresO +
                  "\np = " + caracteresP +
                  "\nq = " + caracteresQ +
                  "\nr = " + caracteresR +
                  "\ns = " + caracteresS +
                  "\nt = " + caracteresT +
                  "\nu = " + caracteresU +
                  "\nv = " + caracteresV +
                  "\nw = " + caracteresW +
                  "\nx = " + caracteresX +
                  "\ny = " + caracteresY +
                  "\nz = " + caracteresZ);
        }
    }
}
