using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] inputArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] inputArray = new int[] { 2, 4, 6 };
        int expected = 12;

        // Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected)); // 20
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 3, 5 };
        int expected = -9;

        // Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] inputArray = new int[] { 2, 4, 6, 1, 3, 5 };
        int expected = 12 - 9;

        // Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
