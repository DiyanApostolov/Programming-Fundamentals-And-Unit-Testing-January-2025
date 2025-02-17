using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);

        //Assert.That(result, Is.EqualTo(emptyList));
        //Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> inputList = new() { 42 };
        List<int> expectedList = new() { 42 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6 };
        List<int> expectedList = new() { 7, 7, 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5 };
        List<int> expectedList = new() { 6, 6, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> expectedList = new() { 11, 11, 11, 11, 11 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<int> expectedList = new() { 12, 12, 12, 12, 12, 6 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedList, result);
    }
}
