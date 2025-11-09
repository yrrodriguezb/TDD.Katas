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
    public void Si_IngresoUnNumeroEntre1y7_Debe_RetonarElRomanoCorrespondiente(int numero, string valorEsperado)
    {
        var resultado = new NumeroRomano(numero).ToString();

        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_IngresoElNumero8_Debe_RetornarVIII()
    {
        var resultado = new NumeroRomano(8).ToString();

        resultado.Should().Be("VIII");
    }
}