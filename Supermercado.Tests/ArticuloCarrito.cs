namespace Supermercado.Tests;

public class ArticuloCarrito
{
    public ArticuloCarrito(string nombre, int cantidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
    }

    public int Cantidad { get; set; }
    public string Nombre { get; set; }
}