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

    private object Wrap(string empty, int i)
    {
        throw new NotImplementedException();
    }
}
