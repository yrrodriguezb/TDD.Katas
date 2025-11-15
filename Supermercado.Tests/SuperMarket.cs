namespace Supermercado.Tests;

public class SuperMarket
{
    public SuperMarket()
    {
    }
    
    public Recibo GenerarRecibo(List<ArticuloCarrito> articulos)
    {
        if (articulos.Count > 0)
        {
            return new Recibo(articulos);
        }
        
        return new Recibo(articulos);
    }
}