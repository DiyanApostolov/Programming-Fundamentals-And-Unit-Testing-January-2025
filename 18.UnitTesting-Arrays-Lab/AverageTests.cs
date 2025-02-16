using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] inputNumbers = { 42 };
        int expected = 42;

        // Act
        double result = Average.CalculateAverage(inputNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] inputNumbers = new int[] { 1, 2, 3 };
        double expected = 6.0 / 3;

        // Act
        double actual = Average.CalculateAverage(inputNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange 
        int[] inputNumbers = new int[] { -2, -4 };
        double expected = -6.0 / 2;

        // Act
        double actual = Average.CalculateAverage(inputNumbers);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange 
        int[] inputNumbers = new int[] { 5, -5, 10, 15, -10 };
        double expected = 15.0 / 5;

        // Act
        double actual = Average.CalculateAverage(inputNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputContainsZerosIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange 
        int[] inputNumbers = new int[] { 0, 0, 0, 0 };
        double expected = 0.0 / 4;

        // Act
        double actual = Average.CalculateAverage(inputNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
