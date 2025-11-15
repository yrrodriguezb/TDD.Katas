namespace Supermercado.Tests;

public class SuperMarket
{
    Dictionary<string, Producto> _catalogo = new()
    {
        { "Leche", new Producto("Leche", 1000) },
        { "Arroz", new Producto("Arroz", 1500) },
    };
    
    public Recibo GenerarRecibo(List<ArticuloCarrito> articulos)
    {
        if (articulos.Count > 0)
        {
            decimal total = 0;
            decimal subtotal = 0;
            
            foreach (var articulo in articulos)
            {
                if (_catalogo.ContainsKey(articulo.Nombre))
                {
                    total += (_catalogo[articulo.Nombre].Valor * articulo.Cantidad);
                }
            }
            subtotal = total;
            return new Recibo(articulos, total, 0, subtotal);
        }
        
        return new Recibo(articulos);
    }
}