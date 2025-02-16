using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class ReverseTests
{
    // https://medium.com/@stefanovskyi/unit-test-naming-conventions-dd9208eadbea
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] inputArray = Array.Empty<int>();
        string expected = string.Empty;

        // Act
        string actual = Reverse.ReverseArray(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] inputArray = new int[] { 42 };
        string expected = "42";

        // Act
        string actual = Reverse.ReverseArray(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] inputArray = new int[] { -10, 20, 30 };
        string expected = "30 20 -10";

        // Act
        string actual = Reverse.ReverseArray(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
