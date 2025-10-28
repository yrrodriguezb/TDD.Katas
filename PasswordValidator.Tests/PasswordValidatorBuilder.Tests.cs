using FluentAssertions;

namespace PasswordValidator.Tests;

public class PasswordValidatorBuilderTests
{
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

    [Fact]
    public void Si_SeConfiguraElBuilderConRequiereNumerosEnFalso_Debe_PermitirDeshabilitarValidacionDeNumeros()
    {
        // Arrange
        var passwordValidator = new PasswordValidatorBuilder()
            .RequiereNumeros(false)
            .Build();

        // Act
        bool result = passwordValidator.EsValido("ABCDEFGHIkj_");

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Si_SeConfiguraElBuilderConRequiereGuionEnFalso_Debe_PermitirDeshabilitarValidacionConGuion()
    {
        // Arrange
        var passwordValidator = new PasswordValidatorBuilder()
            .RequiereGuionBajo(false)
            .Build();

        // Act
        bool result = passwordValidator.EsValido("Abcdefgh1");

        // Assert
        result.Should().Be(true);
    }
}
