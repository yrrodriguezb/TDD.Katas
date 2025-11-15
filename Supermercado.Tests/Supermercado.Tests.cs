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
}

public class Producto
{
    public Producto(string nombre, decimal valor)
    {

    }
}