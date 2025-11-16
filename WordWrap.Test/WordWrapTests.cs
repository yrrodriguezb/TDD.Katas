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
        var resultado = Wrap("word word", 3);

        resultado.Should().Be("wor\nd\nwor\nd");
    }

    private static string Wrap(string word, int columna)
    {
        string result = string.Empty;
        string[] palabras = word.Split(" ");
        int iteraciones = 0;
        
        if (word.Length > 0)
        {
            foreach (var palabra in palabras)
            {
                iteraciones++;
                
                if (palabra.Length > columna)
                {
                    for (int index = 0; index < palabra.Length; index++)
                    {
                        if (index > 0 && index % columna == 0)
                            result += "\n";
                        
                        result += palabra[index];
                    }
                }
                else
                {
                    result += palabra;
                }
                
                if (palabras.Length >= 1 && iteraciones < palabras.Length)
                    result += "\n";
            }
            
            return result;
        }
        

        return string.Empty;
    }
}
