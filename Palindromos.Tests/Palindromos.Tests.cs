namespace Palindromos.Tests;

public class PalindromosTests
{
    [Fact]
    public static void Si_SeIngresaUnTextoVacio_Debe_ResponderQueNoEsUnPalindromo()
    {
        EsPalindromo(string.Empty).Should().Be(false);
    }

    [Theory]
    [InlineData("A")]
    [InlineData("B")]
    [InlineData("C")]
    public void Si_SeIngresaLaLetraMayuscula_Debe_RetonarVerdaderoParaIndicarQueEsUnPalindromo(string letra)
    {
        EsPalindromo(letra).Should().Be(true);
    }

    [Theory]
    [InlineData("a")]
    [InlineData("b")]
    [InlineData("c")]
    public void Si_SeIngresaLaLetraAMinuscula_Debe_RetornarVerdaderoParaIndicarQueEsUnPalindromo(string letra)
    {
        EsPalindromo(letra).Should().Be(true);
    }

    [Theory]
    [InlineData("AA")]
    [InlineData("BB")]
    [InlineData("aa")]
    [InlineData("bb")]
    public void Si_SeIngresaDosLetrasIguales_Debe_RetornarVerdaderoParaIndicarQueEsUnPalindromo(string str)
    {
        EsPalindromo(str).Should().Be(true);
    }

    [Fact]
    public void Si_SeIngresanDosLetrasUnaMinusculaYUnaMayuscula_Debe_RetornarVerdaderoParaIndicarQueEsUnPalindromo()
    {
        EsPalindromo("aA").Should().Be(true);
    }

    [Theory]
    [InlineData("Aa ")]
    [InlineData(" Aa")]
    [InlineData(" aA ")]
    public void Si_SeIngresanDosLetrasIgualesConEspacios_Debe_RetornarVerdaderoParaIndicarQueEsUnPalindromo(string str)
    {
        EsPalindromo(str).Should().Be(true);
    }

    [Fact]
    public void Si_SeIngresaUnDigito_Debe_RetornarVerdaderoIndicandoQueEsUnPalindromo()
    {
        EsPalindromo("1").Should().Be(true);
    }

    [Fact]
    public void Si_SeIngresaDosDigitosIguales_Debe_RetornarVerdaderoIndicandoQueEsUnPalindromo()
    {
        EsPalindromo("11").Should().Be(true);
    }

    private static bool EsPalindromo(string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            return IterarCaracteres(str);
        }

        return false;
    }

    private static bool IterarCaracteres(string str)
    {
        string cadena = string.Empty;
        var strOriginal = NormalizarString(str);
        int len = strOriginal.Length - 1;

        for (int index = len; index > -1; index--)
        {
            cadena += char.ToLower(strOriginal[index]);
        }

        return strOriginal == cadena;
    }

    private static string NormalizarString(string str)
    {
        return str.ToLower().Trim();
    }
}