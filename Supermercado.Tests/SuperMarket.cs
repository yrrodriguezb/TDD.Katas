namespace Supermercado.Tests;

public class SuperMarket
{
    private List<Producto> _productos = new();
    
    public SuperMarket()
    {
        
    }

    public SuperMarket(List<Producto> productos)
    {
        _productos = productos; 
    }
    public Recibo GenerarRecibo(List<ArticuloCarrito> articulos)
    {
        return new Recibo();
    }

    public List<Producto> Productos => _productos;
}