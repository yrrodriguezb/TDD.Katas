namespace Supermercado.Tests;

public class Producto
{
    public Producto(string nombre, decimal valor)
    {
        Valor = valor;
    }

    public decimal Valor { get; private set; }
}