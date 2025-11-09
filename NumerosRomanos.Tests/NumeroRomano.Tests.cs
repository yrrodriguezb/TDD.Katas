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
    [InlineData(40, "XL")]
    [InlineData(50, "L")]
    [InlineData(90, "XC")]
    public void Si_IngresoUnNumeroEntre1y10_Debe_RetonarElRomanoCorrespondiente(int numero, string valorEsperado)
    {
        var resultado = new NumeroRomano(numero).ToString();

        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_IngresoElNumero100_Debe_RetonarC()
    {
        var resultado = new NumeroRomano(100).ToString();

        resultado.Should().Be("C");
    }

    [Fact]
    public void Si_IngresoElNumero400_Debe_RetonarCD()
    {
        var resultado = new NumeroRomano(400).ToString();

        resultado.Should().Be("CD");
    }
    
    [Fact]
    public void Si_IngresoElNumero500_Debe_RetonarD()
    {
        var resultado = new NumeroRomano(500).ToString();

        resultado.Should().Be("D");
    }
}