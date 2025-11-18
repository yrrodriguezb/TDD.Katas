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
    
    [Fact]
    public void f()
    {
        var resultado = Wrap("word word", 6);

        resultado.Should().Be("word\nword");
    }  
    
    [Fact]
    public void f2()
    {
        var resultado = Wrap("word word", 5);

        resultado.Should().Be("word\nword");
    }
    
    [Fact]
    public void g()
    {
        var resultado = Wrap("word word word", 6);

        resultado.Should().Be("word\nword\nword");
    }
    
    [Fact(DisplayName = "h")]
    public void Si_SeIngresaLaPalabraWORD_WORD_WORD_ConUnValorDeColumna11_Debe_RetornarWORD_WORD_WORD_SeparadosPorEspacioSaltoDelinea()
    {
        var resultado = Wrap("word word word", 11);

        resultado.Should().Be("word word\nword");
    }
        

    private static string Wrap(string word, int columna)
    {
        if (string.IsNullOrEmpty(word))
            return string.Empty;
            
        string[] palabras = word.Split(' ');
        string resultado = string.Empty;
        int longitudLineaActual = 0;

        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];

            if (palabra.Length > columna)
            {
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (j > 0 && j % columna == 0)
                        resultado += "\n";

                    resultado += palabra[j];
                }
                
                if (i < palabras.Length - 1)
                    resultado += "\n";
            }
            else 
            {
                if (i == 0)
                {
                    resultado += palabra;
                    longitudLineaActual = palabra.Length;
                }
                else
                {
                    if (longitudLineaActual + 1 + palabra.Length <= columna)
                    {
                        resultado += " " + palabra;
                        longitudLineaActual += 1 + palabra.Length;
                    }
                    else
                    {
                        resultado += "\n" + palabra;
                        longitudLineaActual = palabra.Length;
                    }
                }
            }
        }
        
        return resultado;
    }

}
