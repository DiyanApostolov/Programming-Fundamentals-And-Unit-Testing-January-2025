using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int number = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(9, 34)]
    [TestCase(12, 144)]
    [TestCase(17, 1597)]
    public void Test_CalculateFibonacci_PositiveInput(int number, int expected)
    {
        // Arrange
        //int number = 9;
        //int expected = 34;

        // Act
        int result = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}