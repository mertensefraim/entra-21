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
        public void Validar_CalcularCelsius_Kelvin01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 30;

            // Act 
            var calcularCelsiusKelvin = temperatura.CalcularCelsius();

            // Assert
            calcularCelsiusKelvin.Should().Be(303.15);
        }

        [Fact]
        public void Validar_CalcularCelsius_Kelvin02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 50;

            // Act 
            var calcularCelsiusKelvin = temperatura.CalcularCelsius();

            // Assert
            calcularCelsiusKelvin.Should().Be(323.15);
        }

        [Fact]
        public void Validar_CalcularCelsius_Farenheit01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "farenheit";
            temperatura.TemperaturaOrigem = 30;

            // Act
            var calcularCelsiusFarenheit = temperatura.CalcularCelsius();

            // Assert
            calcularCelsiusFarenheit.Should().Be(86);
        }     
        
        [Fact]
        public void Validar_CalcularCelsius_Farenheit02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "farenheit";
            temperatura.TemperaturaOrigem = 50;

            // Act
            var calcularCelsiusFarenheit = temperatura.CalcularCelsius();

            // Assert
            calcularCelsiusFarenheit.Should().Be(122);
        }

        [Fact]
        public void Validar_CalcularFarenheit_Celsius01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 0;

            // Act
            var calcularFarenheitCelsius = temperatura.CalcularFarenheit();

            // Assert
            calcularFarenheitCelsius.Should().Be(-17.777777);
        }


        [Fact]
        public void Validar_CalcularFarenheit_Celsius02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "celsius";
            temperatura.TemperaturaOrigem = 50;

            // Act
            var calcularFarenheitCelsius = temperatura.CalcularFarenheit();

            // Assert
            calcularFarenheitCelsius.Should().Be(10);
        }

        [Fact]
        public void Validar_CalcularFarenheit_Kelvin01()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 50;

            // Act
            var calcularFarenheitKelvin = temperatura.CalcularFarenheit();

            // Assert
            calcularFarenheitKelvin.Should().Be(283.15);
        } 
        
        [Fact]
        public void Validar_CalcularFarenheit_Kelvin02()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.EscalaDestino = "kelvin";
            temperatura.TemperaturaOrigem = 00;

            // Act
            var calcularFarenheitKelvin = temperatura.CalcularFarenheit();

            // Assert
            calcularFarenheitKelvin.Should().Be(255.372);
        }

        [Fact]

        public void Validar_CalcularKelvin_Celsius()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura
        }
    }
}
