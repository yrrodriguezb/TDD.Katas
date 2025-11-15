namespace Supermercado.Tests;

public class ArticuloCarrito
{
    public ArticuloCarrito(string nombre, int cantidad)
    {
        Cantidad = cantidad;
    }

    public int Cantidad { get; set; }
}