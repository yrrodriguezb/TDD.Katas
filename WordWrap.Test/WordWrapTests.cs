using AwesomeAssertions;

namespace WordWrap.Test;

public class WordWrapTests
{
    [Fact]
    public void Si_SeIngresaUnTextoVacioYUnValorDeColumna1_Debe_RetornarUnTextoVacio()
    {
        var resultado = Wrap("", 1);
       
        resultado.Should().Be("");
    }

    private static string Wrap(string empty, int i)
    {
        return string.Empty;
    }
}
