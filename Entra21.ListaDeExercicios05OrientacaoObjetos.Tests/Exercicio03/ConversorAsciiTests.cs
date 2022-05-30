﻿using Entra21.ListaDeExercicios05OrientacaoObjetos.Exercicio03;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ListaDeExercicios05OrientacaoObjetos.Tests.Exercicio03
{
    public class ConversorAsciiTests
    {
        [Theory]

            [InlineData('a', 97)]
            [InlineData('b', 98)]
            [InlineData('c', 99)]
            [InlineData('d', 100)]
            [InlineData('e', 101)]
            [InlineData('f', 102)]
            [InlineData('g', 103)]
            [InlineData('h', 104)]
            [InlineData('i', 105)]
            [InlineData('j', 106)]
            [InlineData('k', 107)]
            [InlineData('l', 108)]
            [InlineData('m', 109)]
            [InlineData('n', 110)]
            [InlineData('o', 111)]
            [InlineData('p', 112)]
            [InlineData('q', 113)]
            [InlineData('r', 114)]
            [InlineData('s', 115)]
            [InlineData('t', 116)]
            [InlineData('u', 117)]
            [InlineData('v', 118)]
            [InlineData('w', 119)]
            [InlineData('x', 120)]
            [InlineData('y', 121)]
            [InlineData('z', 122)]

            // Caracteres caixa baixa

            [InlineData('A', 65)]
            [InlineData('B', 66)]
            [InlineData('C', 67)]
            [InlineData('D', 68)]
            [InlineData('E', 69)]
            [InlineData('F', 70)]
            [InlineData('G', 71)]
            [InlineData('H', 72)]
            [InlineData('I', 73)]
            [InlineData('J', 74)]
            [InlineData('K', 75)]
            [InlineData('L', 76)]
            [InlineData('M', 77)]
            [InlineData('N', 78)]
            [InlineData('O', 79)]
            [InlineData('P', 80)]
            [InlineData('Q', 81)]
            [InlineData('R', 82)]
            [InlineData('S', 83)]
            [InlineData('T', 84)]
            [InlineData('U', 85)]
            [InlineData('V', 86)]
            [InlineData('W', 87)]
            [InlineData('X', 88)]
            [InlineData('Y', 89)]
            [InlineData('Z', 90)]

        public void Verificar_ObterCodigoAscii_CaracterA(char caracter, int codigoEsperado)
        {
            // Arrange
            var codigo = new ConversorAscii();
            codigo.Caracter = caracter;

            // Act
            var retornoCodigo = codigo.ObterCodigoAscii();

            // Assert
            retornoCodigo.Should().Be(codigoEsperado);
        }

    }
}
