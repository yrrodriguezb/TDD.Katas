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

}

public class PasswordValidatorBuilder
{
    public PasswordValidatorBuilder ConLongitudMinima(int v)
    {
        return this;
    }

    public PasswordValidator Build()
    {
        throw new NotImplementedException();
    }
}