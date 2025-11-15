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

    public ReadOnlyCollection<ArticuloCarrito> Articulos => _articulos.AsReadOnly();
    public decimal Total => _total;
    public decimal SubTotal => _subTotal;
    public decimal Descuentos => _descuentos;
}