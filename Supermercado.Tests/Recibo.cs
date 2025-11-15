using System.Collections.ObjectModel;

namespace Supermercado.Tests;

public class Recibo
{
    private List<ArticuloCarrito> _articulos = new();
    private decimal _total = 0;
    private decimal _subTotal = 0;
    private decimal _descuentos = 0;
    
    public Recibo(List<ArticuloCarrito> articulos)
    {
        _articulos  = articulos;
    }

    public Recibo(List<ArticuloCarrito> articulos, decimal total, decimal descuentos, decimal subTotal)
    {
        _articulos = articulos;
        _total = total;
        _subTotal = subTotal;
        _descuentos = descuentos;
    }

    public ReadOnlyCollection<ArticuloCarrito> Articulos => _articulos.AsReadOnly();
    public decimal Total => _total;
    public decimal SubTotal => _subTotal;
    public decimal Descuentos => _descuentos;
}