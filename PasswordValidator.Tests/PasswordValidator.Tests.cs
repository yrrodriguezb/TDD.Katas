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
}


public class PasswordValidator
{
    public bool Validate(string password)
    {
        return !(password == string.Empty);
    }
}