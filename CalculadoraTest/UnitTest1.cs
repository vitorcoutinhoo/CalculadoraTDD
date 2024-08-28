using Calculadora.Entity;
namespace calculadoratest;

public class UnitTest {
    protected Calc calc = new();

    [Fact]
    public void Somar5com10Resultar15() {
        int a = 5;
        int b = 10;

        Assert.Equal(15, calc.Sum(a, b));
    }

    [Fact]
    public void Subtrair15de23eMeioResultar8eMeio() {
        double a = 23.5;
        int b = 15;

        Assert.Equal(8.5, calc.Subtract(a, b));
    }

    [Fact]
    public void Multiplicar5eMeiopor4eMeioResultar24ponto75() {
        double a = 5.5;
        double b = 4.5;

        Assert.Equal(24.75, calc.Multiply(a, b));
    }

    [Fact]
    public void Dividir10por2Resultar5() {
        int a = 10;
        int b = 2;

        Assert.Equal(5, calc.Divide(a, b));
    }

    [Fact]
    public void Dividir10por0LancarExcecao() {
        int a = 10;
        int b = 0;

        Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
    }

    [Fact]
    public void Ultimos3ResultadosDeveSer5_8eMeioe15() {
        calc.Sum(10, 5);
        calc.Subtract(23.5, 15);
        calc.Divide(10, 2);

        Assert.Equal([5, 8.5, 15], calc.Last3Results);
    }
}