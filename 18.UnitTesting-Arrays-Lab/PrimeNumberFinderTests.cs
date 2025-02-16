using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = new int[] { 1, -1, 0 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = new int[] { 4 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        // Assert 
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = new int[] { 4, 6, 12, 10 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
        //Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] inputArray = new int[] { 4, 6, 12, 10, 7 };
        int[] expected = new int[] { 7 };

        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] inputArray = new int[] { 4, 6, 12, 10, 7, 2, 12, 5 };
        int[] expected = new int[] { 7, 2, 5 };

        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
