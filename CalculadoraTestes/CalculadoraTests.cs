using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        // Act
        int resultadoDaSoma = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoDaSoma);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(9, 5, 4)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        // Act
        int resultadoDaSubtracao = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoDaSubtracao); 
    }

    [Theory]
    [InlineData(2, 4, 8)]
    [InlineData(6, 2, 12)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        // Act
        int resultadoDaMultiplicacao = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoDaMultiplicacao);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(6, 2, 3)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        // Act
        int resultadoDaDivisao = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoDaDivisao);
    }
}