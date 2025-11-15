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
    public void Si_SeInicializaUnSupermercado_Debe_RetornarUnReciboConSusValoresPorDefectoSiNoTieneArticulosEnELCarrito()
    {
        var  supermercado = new SuperMarket();

        Recibo recibo = supermercado.GenerarRecibo([]);

        recibo.Articulos.Should().BeEmpty();
        recibo.SubTotal.Should().Be(0);
        recibo.Total.Should().Be(0);
    }

    [Fact]
    public void Si_SeInicializaUnSupermercado_Debe_TenerUnCatalogoDeProductos()
    {
        var productos = new List<Producto>()
        {
            new("Leche", 1000m)
        };
        var supermecado = new SuperMarket(productos);
        
        supermecado.Productos.Should().BeEquivalentTo(productos);
    }

    [Fact]
    public void Si_GeneroUnReciboConElProductoLeche_Debe_TenerUnArticuloUnTotalDe1000()
    {
        var supermecado = new SuperMarket();
        var articulosCarrito = new List<ArticuloCarrito>();
        articulosCarrito.Add(new ArticuloCarrito("Leche", 1));
        
        var recibo = supermecado.GenerarRecibo(articulosCarrito);
        
        recibo.Articulos.Count.Should().Be(1);
        recibo.SubTotal.Should().Be(1000);
        recibo.Total.Should().Be(1000);
    }

    [Fact]
    public void Si_GeneroUnReciboConDosProductosTipoLeche_Debe_TenerDosArticulosUnTotalDe2000()
    {
        var supermecado = new SuperMarket();
        var articulosCarrito = new List<ArticuloCarrito>
        {
            new("Leche", 2)
        };
        
        var recibo = supermecado.GenerarRecibo(articulosCarrito);
        
        recibo.Articulos.Count.Should().Be(2);
        recibo.SubTotal.Should().Be(2000);
        recibo.Total.Should().Be(2000);
    }
}