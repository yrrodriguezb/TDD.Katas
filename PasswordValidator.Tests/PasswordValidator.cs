namespace PasswordValidator.Tests;

public class PasswordValidator
{
    private int _LongitudMinima { get; set; }
    public bool TieneMayusculas { get; set; }
    public bool TieneMinusculas { get; set; }

    public PasswordValidator()
    {
        _LongitudMinima = 8;
        TieneMayusculas = true;
        TieneMinusculas = true;
    }

    public bool EsValido(string password)
    {
        string newPassword = LimpiarTexto(password);

        return !TieneError(newPassword);
    }

    private bool TieneError(string newPassword)
    {
        return ReglasPassword.EsNuloOVacio(newPassword)
            || ReglasPassword.NoTieneLongitudMinimaRequerida(newPassword, _LongitudMinima)
            || (TieneMayusculas && ReglasPassword.NoTieneMayusculas(newPassword))
            || (TieneMinusculas && ReglasPassword.NoTieneMinusculas(newPassword))
            || ReglasPassword.NoTieneNumeros(newPassword)
            || ReglasPassword.NoTieneGuionBajo(newPassword);
    }

    private static string LimpiarTexto(string password)
    {
        return password.Trim();
    }

    public void SetLongitudMinima(int v)
    {
        _LongitudMinima = v;
    }
}