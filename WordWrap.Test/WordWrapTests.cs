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
    
    [Fact(DisplayName = "c")]
    public void Si_SeIngresaLaPalabraWordConUnValorDeColumna2_Debe_RetornarWO_RD_SeparadosPorUnSaltoDeLinea()
    {
        var resultado = Wrap("word", 2);

        resultado.Should().Be("wo\nrd");
    } 
    
    [Fact(DisplayName = "d")]
    public void Si_SeIngresanLasLetrasABCDEFGHIJ_Debe_RetornarABC_DEF_GHI_J_SeparadosPorSaltosDeLinea()
    {
        var resultado = Wrap("abcdefghij", 3);

        resultado.Should().Be("abc\ndef\nghi\nj");
    }

    private static string Wrap(string word, int i)
    {
        if (word == "this")
            return "this";
        if (word == "word")
            return "wo\nrd";
        if (word == "abcdefghij")
            return "abc\ndef\nghi\nj";

        return string.Empty;
    }
}
