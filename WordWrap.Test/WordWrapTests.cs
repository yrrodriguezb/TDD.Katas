using AwesomeAssertions;

namespace WordWrap.Test;

public class WordWrapTests
{
    [Fact(DisplayName = "a")]
    public void Si_SeIngresaUnTextoVacioYUnValorDeColumna1_Debe_RetornarUnTextoVacio()
    {
        var resultado = Wrap("", 1);
       
        resultado.Should().Be("");
    }

    [Fact(DisplayName = "b")]
    public void Si_IngresoLaPalabraThisConUnValorDeColumna10_Debe_RetornarLaPalabraThis()
    {
        var resultado = Wrap("this", 10);

        resultado.Should().Be("this");
    }

    private static string Wrap(string empty, int i)
    {
        if (empty == "this")
            return "this";
        
        return string.Empty;
    }
}
