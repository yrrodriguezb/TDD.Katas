
using FluentAssertions;

namespace PasswordValidator.Tests;

public class PasswordValidatorTests
{
    [Theory]
    [InlineData("", false)]
    [InlineData(" ", false)]
    [InlineData("    ", false)]
    public void Si_IngresoUnTextoConEspaciosOEnBlanco_Debe_ReturnarFalse(string password, bool resultadoEsperado)
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido(password);

        // Assert
        result.Should().Be(resultadoEsperado);
    }

    [Theory]
    [InlineData("a", false)]
    [InlineData("ab", false)]
    [InlineData("abc", false)]
    public void Si_SeIngresaUnTextoConUnaLongitudMenorALaMinima_Debe_ReturnarFalse(string password, bool resultadoEsperado)
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido(password);

        // Assert
        result.Should().Be(resultadoEsperado);
    }

    [Fact]
    public void Si_IngresoUnTextoConUnaLetraMayuscula_Debe_ReturnarTrue()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido("Abcdefgh1_");

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Si_IngresoUnTextoConSoloLetrasMayusculas_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido("ABCDEFGHIJK");

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Si_IngresoUnTextoQueNoTieneALMenosUnNumero_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido("ABCDEFGHIkj");

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Si_IngresoUnTextoQueNoTieneUnGuionBajo_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.EsValido("Abcdefgh1");

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Si_IngresoUnTextoConUnaLongitudMinimaPersonalizada_Debe_PermitirConfigurarLongitudMinima()
    {
        // Arrange
        var passwordValidator = new PasswordValidatorBuilder()
            .ConLongitudMinima(5)
            .Build();

        // Act
        bool result = passwordValidator.EsValido("Abc1_");

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Si_SeConfiguraElBuilderConRequiereMayusculasEnFalso_Debe_PermitirDeshabilitarValidacionDeMayusculas()
    {
        // Arrange
        var passwordValidator = new PasswordValidatorBuilder()
            .RequiereMayusculas(false)
            .ConLongitudMinima(10)
            .Build();

        // Act
        bool result = passwordValidator.EsValido("abcdefgh1_");

        // Assert
        result.Should().Be(true);
    }
    
    [Fact]
    public void Si_SeConfiguraElBuilderConRequiereMinisculasEnFalso_Debe_PermitirDeshabilitarValidacionDeMinisculas()
    {
        // Arrange
        var passwordValidator = new PasswordValidatorBuilder()
            .RequiereMinisculas(false)
            .Build();

        // Act
        bool result = passwordValidator.EsValido("ABCDEFGH1_");

        // Assert
        result.Should().Be(true);
    }

}

public class PasswordValidatorBuilder
{
    private int _longitudMinima = 8;
    private bool _requiereMayusculas = true;
    private bool _requiereMinusculas = true;

    public PasswordValidator Build()
    {
        var passwordValidator = new PasswordValidator();
        passwordValidator.SetLongitudMinima(_longitudMinima);
        passwordValidator.TieneMayusculas = _requiereMayusculas;
        passwordValidator.TieneMinusculas = _requiereMinusculas;
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
}