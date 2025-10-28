namespace PasswordValidator.Tests;

public class ReglasPassword
{
    public static bool EsNuloOVacio(string newPassword)
    {
        return string.IsNullOrEmpty(newPassword);
    }

    public static bool NoTieneGuionBajo(string newPassword)
    {
        return !newPassword.Contains('_');
    }

    public static bool NoTieneMayusculas(string newPassword)
    {
        return !newPassword.Any(char.IsUpper);
    }

    public static bool NoTieneMinusculas(string newPassword)
    {
        return !newPassword.Any(char.IsLower);
    }

    public static bool NoTieneNumeros(string newPassword)
    {
        return !newPassword.Any(char.IsDigit);
    }

    public static bool NoTieneLongitudMinimaRequerida(string newPassword, int longitudMinima)
    {
        return newPassword.Length < longitudMinima;
    }
}