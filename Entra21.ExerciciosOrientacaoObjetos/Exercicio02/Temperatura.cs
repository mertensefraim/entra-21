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
        public double TemperaturaOrigem;

        public double CalcularCelsius()
        {
            if (EscalaDestino == "kelvin")
                return TemperaturaOrigem + 273.15;

            return TemperaturaOrigem * 1.8 + 32;
        }

        public double CalcularKelvin()
        {
            if (EscalaDestino == "celsius")
                return TemperaturaOrigem - 273.15;

            return (TemperaturaOrigem - 273.15) * 1.8 + 32; 
        }

        public double CalcularFarenheit()
        {
            if (EscalaDestino == "celsius")
                return (TemperaturaOrigem - 32) * 5 / 9;

            return (TemperaturaOrigem - 32) * 5 / 9 + 273.15;
        }

        public double VerificarEscalaOrigem()
        {
            if (EscalaOrigem == "celsius")
                return CalcularCelsius();

            else if (EscalaOrigem == "kelvin")
                return CalcularKelvin();

            else
                return CalcularFarenheit();
        }
    }
}
