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

    private static bool EsPalindromo(string str)
    {
        if (EsTipoChar(str, out char caracter))
        {
            return EsUnaLetra(caracter);
        }

        return false;
    }

    private static bool EsUnaLetra(int valorAscii)
    {
        return EsLetraMayuscula(valorAscii) || EsLetraMinuscula(valorAscii);
    }

    private static bool EsLetraMinuscula(int valorAscii)
    {
        return valorAscii > 96 && valorAscii < 122;
    }

    private static bool EsLetraMayuscula(int valorAscii)
    {
        return valorAscii > 64 && valorAscii < 91;
    }

    private static bool EsTipoChar(string str, out char caracter)
    {
        return char.TryParse(str, out caracter);
    }
}