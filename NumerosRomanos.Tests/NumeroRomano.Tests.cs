using FluentAssertions;

namespace NumerosRomanos.Tests;

public class NumerosRomanosTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    public void Si_IngresoUnNumeroEntre1y10_Debe_RetonarElRomanoCorrespondiente(int numero, string valorEsperado)
    {
        var resultado = new NumeroRomano(numero).ToString();

        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_IngresoElNumero40_Debe_RetornarXL()
    {
        var resultado = new NumeroRomano(40).ToString();

        resultado.Should().Be("XL");
    }

    [Fact]
    public void Si_IngresoElNumero50_Debe_RetornarL()
    {
        var resultado = new NumeroRomano(50).ToString();

        resultado.Should().Be("L");
    }

    [Fact]
    public void Si_IngresoElNumero90_Debe_RetornarXC()
    {
        var resultado = new NumeroRomano(90).ToString();

        resultado.Should().Be("XC");
    }
}