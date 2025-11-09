namespace NumerosRomanos.Tests;

public class NumeroRomano
{
    private readonly int _numero;
    private readonly string _romano = string.Empty;

    private readonly Dictionary<int, string> _numerosRomanos = new()
    {
        {1, "I"},
        {2, "II"},
        {3, "III"},
        {4, "IV"},
        {5, "V"},
        {6, "VI"},
        {7, "VII"},
        {8, "VIII"},
        {9, "IX"}
    };

    public NumeroRomano(int numero)
    {
        _numero = numero;
        _romano = ConvertirARomano();
    }

    private string ConvertirARomano()
    {
        if (_numerosRomanos.ContainsKey(_numero))
        {
            return _numerosRomanos[_numero];
        }

        return string.Empty;
    }

    public override string ToString()
    {
        return _romano;
    }
}