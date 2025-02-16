using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] inputArray = Array.Empty<double>();
        double[] excepted = Array.Empty<double>();

        // Act
        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        // Assert
        CollectionAssert.AreEqual(actual, excepted);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] inputArray = Array.Empty<double>();
        double[] excepted = Array.Empty<double>();

        // Act
        double[] actual = Sorting.DeepAscendingSort(inputArray);

        // Assert
        CollectionAssert.AreEqual(actual, excepted);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] inputArray = new double[] { 3, 2, 1 };
        double[] excepted = new double[] { 1, 2, 3 };

        // Act
        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        // Assert
        CollectionAssert.AreEqual(actual, excepted);
        CollectionAssert.AreNotEqual(actual, inputArray);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] inputArray = new double[] { 3, 2, 1 };
        double[] excepted = new double[] { 1, 2, 3 };

        // Act
        double[] actual = Sorting.DeepAscendingSort(inputArray);

        // Assert
        CollectionAssert.AreEqual(actual, excepted);
        CollectionAssert.AreEqual(actual, inputArray);
    }
}
