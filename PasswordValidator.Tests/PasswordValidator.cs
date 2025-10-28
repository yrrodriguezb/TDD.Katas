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

      
        if (string.IsNullOrEmpty(newPassword) || 
            NoTieneLongitudMinimaRequerida(newPassword) || 
            !newPassword.Any(char.IsUpper))
        {
            return false;
        }

        return true;
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