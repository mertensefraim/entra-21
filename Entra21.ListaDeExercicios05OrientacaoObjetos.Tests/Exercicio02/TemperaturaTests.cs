using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Tests.Exercicio02
{
    public class TemperaturaTests
    {
        [Fact]
        public void Validar_CalcularCelsiusParaKelvin01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 20;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(293.15);
        }

        [Fact]
        public void Validar_CalcularCelsiusParaKelvin02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -20;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(253.14999999999998);
        }

        [Fact]
        public void Validar_CalcularCelsiusParaFahrenhait01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(86);
        }    
        [Fact]
        public void Validar_CalcularCelsiusParaFahrenhait02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -20;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(-4);
        }

        [Fact]
        public void Validar_CalcularKelvinParaCelsius01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(-243.14999999999998);
        }

        [Fact]
        public void Validar_CalcularKelvinParaCelsius02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -20;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(-293.14999999999998);
        }

        [Fact]
        public void Validar_CalcularKelvinParaFahrenheit01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(-405.66999999999996);
        }

        [Fact]
        public void Validar_CalcularKelvinFahrenheit02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -20;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(-495.66999999999996);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaCelsius01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(-1.1111111111111112);
        }
        
        [Fact]
        public void Validar_CalcularFahrenheitParaCelsius02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -20;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(-28.88888888888889);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaKelvin01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 30;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(272.0388888888889);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaKelvin02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = -30;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(238.70555555555552);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "celsius";
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 30;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(303.15);
        }
    }
}
