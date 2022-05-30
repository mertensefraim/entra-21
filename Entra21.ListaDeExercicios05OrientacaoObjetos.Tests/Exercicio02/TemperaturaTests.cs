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
        public void Validar_ApresentarTemperaturaConvertida_CelsiusParaKelvin01()
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
        
        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_CelsiusParaKelvin02()
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

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_CelsiusParaFahrenheit01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "celsius";
            temperatura.EscalaDestino = "fahrenheit";
            temperatura.TemperaturaOrigem = 10;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(50);
        }        
        
        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_CelsiusParaFahrenheit02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "celsius";
            temperatura.EscalaDestino = "fahrenheit";
            temperatura.TemperaturaOrigem = 40;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(104);
        }        
        
        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_KelvinParaCelsius01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "kelvin";
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 300;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(26.850000000000023);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_KelvinParaCelsius02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "kelvin";
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 100;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(-173.14999999999998);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_KelvinParaFahrenheit01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "kelvin";
            temperatura.EscalaDestino = "fahrenheit";
            temperatura.TemperaturaOrigem = 100;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(-279.66999999999996);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_KelvinParaFahrenheit02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "kelvin";
            temperatura.EscalaDestino = "fahrenheit";
            temperatura.TemperaturaOrigem = 300;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(80.33000000000004);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_FahrenheitParaCelsius01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "fahrenheit";
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 50;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(10);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_FahrenheitParaCelsius02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "fahrenheit";
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 104;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(40);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_FahrenheitParaKelvin01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "fahrenheit";
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 40;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(277.59444444444443);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_FahrenheitParaKelvin02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "fahrenheit";
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 85;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(302.59444444444443);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_EscalasIguais01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "fahrenheit";
            temperatura.EscalaDestino = "fahrenheit";
            temperatura.TemperaturaOrigem = 85;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(85);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_EscalasIguais02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "celsius";
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 30;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(30);
        }

        [Fact]
        public void Validar_ApresentarTemperaturaConvertida_EscalasIguais03()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaOrigem = "kelvin";
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 20;

            // Act
            var apresentarTemperatura = temperatura.ApresentarTemperaturaConvertida();

            // Assert
            apresentarTemperatura.Should().Be(20);
        }
    }
}
