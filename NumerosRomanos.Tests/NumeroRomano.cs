namespace NumerosRomanos.Tests;

public class NumeroRomano
{
    private readonly int _numero;
    private readonly string _romano = string.Empty;

    public NumeroRomano(int numero)
    {
        _numero = numero;
        _romano = ConvertirARomano();
    }

    private string ConvertirARomano()
    {
        if (_numero == 1) return "I";
        if (_numero == 2) return "II";
        if (_numero == 3) return "III";
        return string.Empty;
    }

    public override string ToString()
    {
        return _romano;
    }
}