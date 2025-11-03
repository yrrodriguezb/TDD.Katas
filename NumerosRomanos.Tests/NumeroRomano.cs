namespace NumerosRomanos.Tests;

public class NumeroRomano
{
    private readonly int _numero;

    public NumeroRomano(int numero)
    {
        _numero = numero;
    }

    public override string ToString()
    {
        if (_numero == 1) return "I";

        return "II";
    }
}