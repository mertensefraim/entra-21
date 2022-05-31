using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio04;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Tests.Exercicio04
{
    public class FarmaciaTests
    {
        [Theory]
        [InlineData(30.4, 58.3, 98.4, 187.1)]
        [InlineData(45, 56, 23, 124)]
        public void Validar_ObterTotalAntiinflamatorios(double valor1, double valor2, double valor3, double somaEsperada)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.PrecosProdutos[0] = valor1;
            farmacia.PrecosProdutos[1] = valor2;
            farmacia.PrecosProdutos[2] = valor3;

            // Act
            var somaTotal = farmacia.ObterTotalDoPedido();

            //Assert
            somaTotal.Should().Be(somaEsperada);
        }
    }
}
