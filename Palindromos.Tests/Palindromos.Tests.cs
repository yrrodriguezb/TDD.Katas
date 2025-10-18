namespace Palindromos.Tests;

public class PalindromosTests
{
    [Fact]
    public static void Si_SeIngresaUnTextoVacio_Debe_ResponderQueNoEsUnPalindromo()
    {
        EsPalindromo(string.Empty).Should().Be(false);
    }

    [Fact]
    public void Si_SeIngresaLaLetraA_Debe_RetonarVerdaderoParaIndicarQueEsUnPalindromo()
    {
        EsPalindromo("A").Should().Be(true);
    }

    private static bool EsPalindromo(string str)
    {
        if (str == "A")
            return true;
            
        return false;
    }
}