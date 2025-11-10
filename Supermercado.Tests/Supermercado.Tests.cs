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
}

public class ArticuloCarrito
{
}

public class Recibo
{
}

public class SuperMarket
{
    public Recibo GenerarRecibo(List<ArticuloCarrito> list)
    {
        throw new NotImplementedException();
    }
}