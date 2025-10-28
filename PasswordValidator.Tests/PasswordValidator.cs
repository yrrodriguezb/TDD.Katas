namespace PasswordValidator.Tests;

public class PasswordValidator
{
    private int _LongitudMinima { get; set; }

    public PasswordValidator()
    {
        _LongitudMinima = 8;
    }

    public bool Validate(string password)
    {
        string newPassword = LimpiarTexto(password);

        if (EsNuloOVacio(newPassword) ||
            NoTieneLongitudMinimaRequerida(newPassword) ||
            NoTieneMayusculas(newPassword))
        {
            return false;
        }

        return true;
    }

    private static bool EsNuloOVacio(string newPassword)
    {
        return string.IsNullOrEmpty(newPassword);
    }

    private static bool NoTieneMayusculas(string newPassword)
    {
        return !newPassword.Any(char.IsUpper);
    }

    private bool NoTieneLongitudMinimaRequerida(string newPassword)
    {
        return newPassword.Length < _LongitudMinima;
    }

    private static string LimpiarTexto(string password)
    {
        return password.Trim();
    }
}