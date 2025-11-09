namespace NumerosRomanos.Tests;

public class NumeroRomano
{
    private readonly int _numero;
    private readonly string _romano = string.Empty;

    private readonly Dictionary<int, string> _numerosRomanos = new()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"}
    };

    public NumeroRomano(int numero)
    {
        _numero = numero;
        _romano = ConvertirARomano();
    }

    private string ConvertirARomano()
    {
        foreach (var item in _numerosRomanos.OrderByDescending(n => n.Key))
        {
            if (_numero == item.Key)
            {
                return item.Value;
            }
            if (_numero > item.Key)
            {
                return item.Value + new NumeroRomano(_numero - item.Key).ToString();
            }
        }

        return string.Empty;
    }

    public override string ToString()
    {
        return _romano;
    }
}