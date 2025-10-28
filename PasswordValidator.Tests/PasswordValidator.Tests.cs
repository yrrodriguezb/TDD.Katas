using FluentAssertions;

namespace PasswordValidator.Tests;

public class PasswordValidatorTests
{
    [Fact]
    public void Si_SeIngresaUnTextoVacio_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();
        string password = "";

        // Act
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Si_SeIngresaUnTextoConEspacios_Debe_ReturnarFalse()
    {
        // Arrange
        var passwordValidator = new PasswordValidator();
        string password = " ";

        // Act
        bool result = passwordValidator.Validate(password);

        // Assert
        result.Should().Be(false);
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
}


public class PasswordValidator
{
    public bool Validate(string password)
    {
        string newPassword = LimpiarTexto(password);
        return !string.IsNullOrEmpty(newPassword);
    }

    private static string LimpiarTexto(string password)
    {
        return password.Trim();
    }
}