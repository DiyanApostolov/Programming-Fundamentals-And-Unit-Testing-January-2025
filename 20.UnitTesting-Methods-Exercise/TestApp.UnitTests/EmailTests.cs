using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidmail = "test@";

        // Act
        bool result = Email.IsValidEmail(invalidmail);

        // Assert
        Assert.IsFalse(result);
    }

    [TestCase(null)]
    [TestCase(" ")]
    public void Test_IsValidEmail_NullInput(string mail)
    {
        // Arrange

        // Act
        bool result = Email.IsValidEmail(mail);

        // Assert
        Assert.IsFalse(result);
    }
}
