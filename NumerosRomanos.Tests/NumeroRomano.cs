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
        if (_numero == 4)
            return "IV";

        if (_numero == 5)
            return "V";
            
        return string.Concat(Enumerable.Repeat("I", _numero));
    }

    public override string ToString()
    {
        return _romano;
    }
}