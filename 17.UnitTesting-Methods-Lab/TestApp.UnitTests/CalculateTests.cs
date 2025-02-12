using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new();
        int firstNum = 5;
        int secondNum = 2;
        int expected = 3;

        // Act
        int actual = calculator.Subtraction(firstNum, secondNum);

        // Assert
        Assert.AreEqual(expected, actual, "Subtraction did not work properly.");
    }
}
