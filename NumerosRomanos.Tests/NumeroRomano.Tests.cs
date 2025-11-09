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
    [InlineData(100, "C")]
    [InlineData(400, "CD")]
    [InlineData(500, "D")]
    public void Si_IngresoUnNumeroEntre1y10_Debe_RetonarElRomanoCorrespondiente(int numero, string valorEsperado)
    {
        var resultado = new NumeroRomano(numero).ToString();

        resultado.Should().Be(valorEsperado);
    }

    [Fact]
    public void Si_IngresoElNumero900_Debe_Retonar_CM()
    {
        var resultado = new NumeroRomano(900).ToString();

        resultado.Should().Be("CM");
    }
    
    [Fact]
    public void Si_IngresoElNumero1000_Debe_Retonar_M()
    {
        var resultado = new NumeroRomano(1000).ToString();

        resultado.Should().Be("M");
    }
}