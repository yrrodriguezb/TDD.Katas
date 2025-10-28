namespace PasswordValidator.Tests;

public class PasswordValidatorBuilder
{
    private int _longitudMinima = 8;
    private bool _requiereMayusculas = true;
    private bool _requiereMinusculas = true;
    private bool _requiereNumeros = true;
    private bool _requiereGuionesBajo = true;

    public PasswordValidator Build()
    {
        var passwordValidator = new PasswordValidator();
        passwordValidator.SetLongitudMinima(_longitudMinima);
        passwordValidator.TieneMayusculas = _requiereMayusculas;
        passwordValidator.TieneMinusculas = _requiereMinusculas;
        passwordValidator.TieneNumeros = _requiereNumeros;
        passwordValidator.TieneGuionBajo = _requiereGuionesBajo;
        return passwordValidator;
    }

    public PasswordValidatorBuilder ConLongitudMinima(int longitudMinima)
    {
        _longitudMinima = longitudMinima;
        return this;
    }

    public PasswordValidatorBuilder RequiereMayusculas(bool requiere)
    {
        _requiereMayusculas = requiere;
        return this;
    }

    public PasswordValidatorBuilder RequiereMinisculas(bool requiere)
    {
        _requiereMinusculas = requiere;
        return this;
    }

    public PasswordValidatorBuilder RequiereNumeros(bool requiere)
    {
        _requiereNumeros = requiere;
        return this;
    }

    public PasswordValidatorBuilder RequiereGuionBajo(bool requiere)
    {
        _requiereGuionesBajo = requiere;
        return this;
    }
}
