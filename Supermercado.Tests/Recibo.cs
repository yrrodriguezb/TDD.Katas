namespace Supermercado.Tests;

public class Recibo
{
    public List<ArticuloCarrito> Articulos { get; set; } = [];
    public decimal Total { get; }
    public decimal SubTotal { get; }
}