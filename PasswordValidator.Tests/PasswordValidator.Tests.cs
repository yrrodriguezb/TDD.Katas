using FluentAssertions;

namespace PasswordValidator.Tests;

public class PasswordValidatorTests
{
    [Theory]
    [InlineData("", false)]
    [InlineData(" ", false)]
    [InlineData("    ", false)]
    public void ValidarContraseña(string password, bool expectedResult)
    {
        // Arrange
        var passwordValidator = new PasswordValidator();

        // Act
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Si_SeIngresaUnTextoConUnCaracter_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();
        string password = "a";

        // Act
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Si_SeIngresaUnTextoConDosCaracteres_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();
        string password = "ab";

        // Act
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(false);
    }
}


public class PasswordValidator
{
    public bool Validate(string password)
    {
        string newPassword = LimpiarTexto(password);

        return newPassword.Length == 1 ? false : !string.IsNullOrEmpty(newPassword);
    }

    private static string LimpiarTexto(string password)
    {
        return password.Trim();
    }
}