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

        public double CalcularCelsiusParaKelvin()
        {
            return TemperaturaOrigem + 273.15;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            return TemperaturaOrigem * 9 / 5 + 32;
        }

        public double CalcularKelvinParaCelsius()
        {
            return TemperaturaOrigem - 273.15;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            return (TemperaturaOrigem - 273.15) * 9 / 5 + 32;
        }

        public double CalcularFahrenheitParaCelsius()
        {
            return (TemperaturaOrigem - 32) * 5 / 9;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            return (TemperaturaOrigem - 32) * 5 / 9 + 273.15;
        }
        public double ApresentarTemperaturaConvertida()
        {
            if (EscalaOrigem == "celsius" && EscalaDestino == "kelvin")
                return CalcularCelsiusParaKelvin();

            else if (EscalaOrigem == "celsius" && EscalaDestino == "fahrenheit")
                return CalcularCelsiusParaFahrenheit();

            else if (EscalaOrigem == "kelvin" && EscalaDestino == "celsius")
                return CalcularKelvinParaCelsius();

            else if (EscalaOrigem == "kelvin" && EscalaDestino == "fahrenheit")
                return CalcularKelvinParaFahrenheit();

            else if (EscalaOrigem == "fahrenheit" && EscalaDestino == "celsius")
                return CalcularFahrenheitParaCelsius();

            else if (EscalaOrigem == "fahrenheit" && EscalaDestino == "kelvin")
                return CalcularFahrenheitParaKelvin();

            return TemperaturaOrigem;
        }
    }
}
