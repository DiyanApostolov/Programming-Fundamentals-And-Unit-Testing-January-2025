using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act 
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }
    

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        // Arrange
        List<int> onlyNegativeList = new() { -3, -5, -12, -1 };

        // Act 
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyNegativeList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        // Arrange
        List<int> onlyOneElementList = new() { 42 };

        // Act 
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyOneElementList);

        // Assert
        CollectionAssert.AreEqual(onlyOneElementList, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        // Arrange
        List<int> onlyPositiveList = new() { 6, 2, 13, 25, 8 };
        List<int> expected = new() { 8, 25, 13, 2, 6 };

        // Act 
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyPositiveList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        // Arrange
        List<int> onlyPositiveList = new() { 6, -2, 13, -25, 8, 7 };
        List<int> expected = new() { 7, 8, 13, 6 };

        // Act 
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyPositiveList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
