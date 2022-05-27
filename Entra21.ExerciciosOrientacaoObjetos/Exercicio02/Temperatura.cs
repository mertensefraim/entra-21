using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string EscalaOrigem;
        public string EscalaDestino;
        public int TemperaturaOrigem;

        public double CalcularCelsius()
        {
            if (EscalaOrigem == "kelvin")
                return TemperaturaOrigem + 273;

            return TemperaturaOrigem * 1.8 + 32;
        }

        public double CalcularKelvin()
        {
            if (EscalaOrigem == "celsius")
                return TemperaturaOrigem - 273;

            return (TemperaturaOrigem - 273.15) * 1.8 + 32; 
        }

        public double CalcularFarenheit()
        {
            if (EscalaOrigem == "celsius")
                return (TemperaturaOrigem - 32) * 1.8;

            return (TemperaturaOrigem - 32) * 1.8 + 273.15;
        }

        public void VerificarEscalaOrigem()
        {
            if (EscalaOrigem == "celsius")
                CalcularCelsius();

            else if (EscalaOrigem == "kelvin")
                CalcularKelvin();

            else
                CalcularFarenheit();
        }
    }
}
