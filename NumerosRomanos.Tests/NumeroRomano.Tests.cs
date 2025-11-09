using FluentAssertions;

namespace NumerosRomanos.Tests;

public class NumerosRomanosTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    public void Si_IngresoUnNumeroEntre1y3_Debe_RetonarElRomanoCorrespondiente(int numero, string valorEsperado)
    {
        var resultado = new NumeroRomano(numero).ToString();

        resultado.Should().Be(valorEsperado);
    }
    
    [Fact]
    public void Si_IngresoElNumero4_Debe_RetornarIV()
    {
        var resultado = new NumeroRomano(4).ToString();

        resultado.Should().Be("IV");
    }
}