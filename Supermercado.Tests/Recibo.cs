using System.Collections.ObjectModel;

namespace Supermercado.Tests;

public class Recibo
{
    private List<ArticuloCarrito> _articulos = new();
    private int _total = 0;
    private int _subTotal = 0;

    public Recibo()
    {
        
    }
    
    public Recibo(List<ArticuloCarrito> articulos)
    {
        _articulos  = articulos;
        _total = 1000;
        _subTotal = 1000;
    }

    public ReadOnlyCollection<ArticuloCarrito> Articulos => _articulos.AsReadOnly();
    public decimal Total => _total;
    public decimal SubTotal => _subTotal;
}