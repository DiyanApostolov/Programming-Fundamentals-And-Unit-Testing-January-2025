using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[0], "")]
    [TestCase(new int[] { 5, 6, 7, 8, 9, 10, 11, 12 }, "13 13 21 21")]
    [TestCase(new int[] { -1, 2, 3, -4, 5, 6, -7, 8 }, "5 -5 13 -1")]
    [TestCase(new int[] { 1, 2, 3, 0, 5, 6, 10, 8, 12, 5, 3, 0 }, "3 7 7 10 11 17")]
    [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, "0 0 0 0")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert 
        CollectionAssert.AreEqual(expected, result);
    }
}
