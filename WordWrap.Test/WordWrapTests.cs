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
    
    [Fact(DisplayName = "e")]
    public void Si_SeIngresaLaPalabraWORD_WORD_ConUnValorDeColumna3_Debe_RetonarWOR_D_WOR_D_SeparadosPorSaltosDeLinea()
    {
        var result = Wrap("word word", 3);

        result.Should().Be("wor\nd\nwor\nd");
    }

    private static string Wrap(string word, int columna)
    {
        string str = string.Empty;
        
        if (word.Length > 0)
        {
            for (int index = 0; index < word.Length; index++)
            {
                if (index > 0 && index % columna == 0)
                    str += "\n";
                
                str += word[index];
            }
            
            return str;
        }
        

        return string.Empty;
    }
}
