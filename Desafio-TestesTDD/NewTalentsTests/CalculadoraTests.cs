using NewTalents;

namespace NewTalentsTests;

public class CalculadoraTests
{

    public Calculadora ConstruirClasse()
    {
        string data = "19/10/2023";
        var calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Somar(val1, val2);

        // Asset
        Assert.Equal(resultado,resultadoCalculadora);
    }


    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        // Asset
        Assert.Equal(resultado,resultadoCalculadora);
    }


    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Subtrair(val1, val2);

        // Asset
        Assert.Equal(resultado,resultadoCalculadora);
    }


    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        int resultadoCalculadora = calc.Dividir(val1, val2);

        // Asset
        Assert.Equal(resultado,resultadoCalculadora);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act / Asset
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }


    [Fact]
    public void TestarHistorico()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();
        
        calc.Somar(1, 2);
        calc.Somar(2, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.Historico();


        // Act / Asset
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}