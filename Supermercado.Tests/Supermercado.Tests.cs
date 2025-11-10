using FluentAssertions;

namespace Supermercado.Tests;


public class SupermercadoTests
{
    [Fact]
    public void Si_SeInicializaUnSupermercado_Debe_RetornarUnRecibo()
    {
        var supermercado = new SuperMarket();

        Recibo recibo = supermercado.GenerarRecibo(new List<ArticuloCarrito>());

        recibo.Should().NotBeNull();
    }

    [Fact]
    public void Si_SeInicializaUnSupermercado_Debe_RetornarReciboConUnaListaDeArticulosVacia()
    {
        var  supermercado = new SuperMarket();

        Recibo recibo = supermercado.GenerarRecibo([]);

        recibo.Articulos.Should().BeEmpty();
    }

    [Fact]
    public void Si_SeInicializaUnSupermercado_Debe_RetornarUnReciboConUnValorTotalDeCero()
    {
        var  supermercado = new SuperMarket();

        Recibo recibo = supermercado.GenerarRecibo([]);

        recibo.Total.Should().Be(0);
    }
    
    [Fact]
    public void Si_SeInicializaUnSupermercado_Debe_RetornarUnReciboConUnValorSubTotalDeCero()
    {
        var  supermercado = new SuperMarket();

        Recibo recibo = supermercado.GenerarRecibo([]);

        recibo.SubTotal.Should().Be(0);
    }
}