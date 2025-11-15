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
        recibo.Descuentos.Should().Be(0);
        recibo.Total.Should().Be(0);
    }

    [Fact]
    public void Si_AgregoUnArticuloTipoLeche_Debe_RetornarUnReciboConUnArticuloTotal1000SubTotal1000Descuentos0()
    {
        var  supermercado = new SuperMarket();
        var articulos = new List<ArticuloCarrito>()
        {
            new("Leche", 1),
        };
        
        Recibo recibo = supermercado.GenerarRecibo(articulos);

        recibo.Articulos.Count().Should().Be(1);
        recibo.SubTotal.Should().Be(1000);
        recibo.Descuentos.Should().Be(0);
        recibo.Total.Should().Be(1000);
    }

    [Fact]
    public void Si_AgregoDosArticulosTipoLeche_Debe_RetornarUnReciboConUnTotal1000SubTotal1000Descuentos0()
    {
        var  supermercado = new SuperMarket();
        var articulos = new List<ArticuloCarrito>()
        {
            new("Leche", 2),
        };
        
        Recibo recibo = supermercado.GenerarRecibo(articulos);

        recibo.SubTotal.Should().Be(2000);
        recibo.Descuentos.Should().Be(0);
        recibo.Total.Should().Be(2000);
    }
    
    [Fact]
    public void Si_AgregoDosArticulosUnoTipoLecheOtroTipoArroz_Debe_RetornarUnReciboConUnTotal2500SubTotal2500Descuentos0()
    {
        var  supermercado = new SuperMarket();
        var articulos = new List<ArticuloCarrito>()
        {
            new("Leche", 1),
            new("Arroz", 1)
        };
        
        Recibo recibo = supermercado.GenerarRecibo(articulos);

        recibo.SubTotal.Should().Be(2500);
        recibo.Descuentos.Should().Be(0);
        recibo.Total.Should().Be(2500);
    }
}