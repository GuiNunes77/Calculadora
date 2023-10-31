using System;
using Xunit;
using CalculadoraApp;

namespace CalculadoraTeste
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "31/10/2023";
            Calculadora _calc = new Calculadora(data);

            return _calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int valor1, int valor2, int resultado)
        {
            Calculadora _calc = construirClasse();

            int resultadoCalculadora = _calc.Somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora _calc = construirClasse();

            int resultadoCalculadora = _calc.Subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora _calc = construirClasse();

            int resultadoCalculadora = _calc.Multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(25, 5, 5)]
        public void TesteDividir(int valor1, int valor2, int resultado)
        {
            Calculadora _calc = construirClasse();

            int resultadoCalculadora = _calc.Dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void DivisaoPorZero()
        {
            Calculadora _calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => _calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora _calc = construirClasse();

            _calc.Somar(1, 2);
            _calc.Somar(3, 4);
            _calc.Somar(5, 6);
            _calc.Somar(7, 8);
            _calc.Somar(9, 10);

            var lista = _calc.Historico();

            Assert.NotEmpty(_calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}