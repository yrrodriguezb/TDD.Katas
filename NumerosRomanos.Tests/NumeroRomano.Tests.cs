using FluentAssertions;

namespace NumerosRomanos.Tests;

public class NumerosRomanosTests
{
    [Fact]
    public void Si_IngresoUno_Debe_RetonarI()
    {
        var resultado = new NumeroRomano(1);

        resultado.ToString().Should().Be("I");
    }

    [Fact]
    public void Si_Ingreso2_Debe_RetornarII()
    {
        var resultado = new NumeroRomano(2);

        resultado.ToString().Should().Be("II");
    }
}