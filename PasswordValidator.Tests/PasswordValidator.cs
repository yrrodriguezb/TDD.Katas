namespace PasswordValidator.Tests;

public class PasswordValidator
{
    private int _LongitudMinima { get; set; }

    public PasswordValidator()
    {
        _LongitudMinima = 8;
    }

    public bool EsValido(string password)
    {
        string newPassword = LimpiarTexto(password);

        return !EsPasswordValido(newPassword);
    }

    private bool EsPasswordValido(string newPassword)
    {
        return EsNuloOVacio(newPassword) 
            || NoTieneLongitudMinimaRequerida(newPassword) 
            || NoTieneMayusculas(newPassword)
            || NoTieneMinusculas(newPassword) 
            || NoTieneNumeros(newPassword);
    }

    private static bool NoTieneNumeros(string newPassword)
    {
        return !newPassword.Any(char.IsDigit);
    }

    private static bool NoTieneMinusculas(string newPassword)
    {
        return !newPassword.Any(char.IsLower);
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