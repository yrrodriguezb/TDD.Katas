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
    public void Si_SeIngresaLaLetraAyB_Debe_RetonarVerdaderoParaIndicarQueEsUnPalindromo(string letra)
    {
        EsPalindromo(letra).Should().Be(true);
    }

    private static bool EsPalindromo(string str)
    {
        return str == "A" || str == "B";
    }
}