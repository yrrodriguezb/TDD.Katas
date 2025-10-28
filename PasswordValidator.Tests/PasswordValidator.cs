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

        return NoTieneLongitudMinimaRequerida(newPassword) ? false : !string.IsNullOrEmpty(newPassword);
    }

    private bool NoTieneLongitudMinimaRequerida(string newPassword)
    {
        return newPassword.Length <= _LongitudMinima;
    }

    private static string LimpiarTexto(string password)
    {
        return password.Trim();
    }
}