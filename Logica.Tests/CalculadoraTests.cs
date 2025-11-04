using Xunit;
using Logica;

namespace Logica.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Sumar_DeberiaRetornarSumaCorrecta()
    {
        var calc = new Calculadora();
        int resultado = calc.Sumar(3, 2);
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Dividir_DeberiaLanzarExcepcion_SiEsDivisionPorCero()
    {
        var calc = new Calculadora();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
    }
}
