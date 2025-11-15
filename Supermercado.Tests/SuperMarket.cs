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
            decimal valor = 1000 * articulos[0].Cantidad;
            return new Recibo(articulos, valor, 0, valor);
        }
        
        return new Recibo(articulos);
    }
}