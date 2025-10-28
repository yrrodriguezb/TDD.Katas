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
        bool result = passwordValidator.Validate(password);

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
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(resultadoEsperado);
    }

    [Fact]
    public void Si_IngresoUnTextoConUnaLetraMayuscula_Debe_ReturnarTrue()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.Validate("Abcdefgh"); 

        // Assert
        result.Should().Be(true);
    }
}