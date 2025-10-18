namespace Palindromos.Tests;

public class PalindromosTests
{
    [Fact]
    public static void Si_SeIngresaUnTextoVacio_Debe_ResponderQueNoEsUnPalindromo()
    {
        var esPalindromo = EsPalindromo("");

        esPalindromo.Should().Be(false);
    }

    private static bool EsPalindromo(string str)
    {
        throw new NotImplementedException();
    }
}