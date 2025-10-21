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

    [Theory]
    [InlineData("1")]
    [InlineData("11")]
    [InlineData("2222")]
    [InlineData("3333333")]
    public void Si_SeIngresaUnoOMasDigitosIguales_Debe_RetornarVerdaderoIndicandoQueEsUnPalindromo(string str)
    {
        EsPalindromo(str).Should().Be(true);
    }

    [Theory]
    [InlineData("6ab1")]
    [InlineData("6axDbTbd6")]
    public void Si_SeIngresanLetrasYNumeros_Debe_RetornarVerdaderoSiEsUnPalindromo(string str)
    {
        EsPalindromo(str).Should().Be(true);
    }

    [Theory]
    [InlineData("Race car")]
    [InlineData("Anna!")]
    [InlineData("A man, a plan, a canal, Panama!")]
    public void Si_SeIngresanFrasesCompuestas_Debe_RetornarVerdaderoSiEsUnPalindromo(string str)
    {
        EsPalindromo(str).Should().Be(true);
    }

    [Theory]
    [InlineData("Race car 1")]
    [InlineData("axDbTbd6")]
    [InlineData("Hello, World!")]
    public void Si_LaEntradaNoEsUnPalindromo_Debe_RetornarFalso(string str)
    {
        EsPalindromo(str).Should().Be(false);
    }
    
    private static bool EsPalindromo(string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            var strOriginal = NormalizarString(str);

            if (TieneLetrasYNumeros(strOriginal))
            {
                var reverseStr = ObtenerTextoAlReves(strOriginal);
                return ConvertirTextoABinario(strOriginal) == ConvertirTextoABinario(reverseStr);
            }

            return ObtenerTextoAlReves(strOriginal) == strOriginal;
        }

        return false;
    }


    private static string ObtenerTextoAlReves(string str)
    {
        return string.Join("", str.Reverse());
    }

    private static string ConvertirTextoABinario(string str)
    {
        string cadena = string.Empty;

        foreach (char caracter in str)
        {
            cadena += char.IsDigit(caracter) ? "1" : "0";
        }

        return cadena;
    }

    private static bool TieneLetrasYNumeros(string str)
    {
        return !string.IsNullOrWhiteSpace(str) 
            && str.Any(char.IsLetter) 
            && str.Any(char.IsDigit);
    }

    private static string NormalizarString(string str)
    {
        return string.Join("", str
            .ToLower()
            .Trim()
            .Where(char.IsLetterOrDigit)
        );
    }
}