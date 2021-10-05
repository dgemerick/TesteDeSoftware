using Demo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demos.Tests
{
    public class CalculadoraTests
    {

        [Fact]
        public void Calculadora_Somar_RetornaValorSoma()
        {
            //Arange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, resultado);
        }
    }
}
