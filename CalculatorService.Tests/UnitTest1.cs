namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }
}