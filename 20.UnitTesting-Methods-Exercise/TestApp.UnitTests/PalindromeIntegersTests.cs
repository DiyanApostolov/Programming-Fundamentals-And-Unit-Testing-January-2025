using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    PalindromeIntegers pi;

    [SetUp]
    public void SetUp()
    {
        pi = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new();

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new() { 308, 234, 1005, 506 };

        // Arrange
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new() { 3, 4, 6, 8 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        // кратък вариант
        CollectionAssert.AreEqual(numbers, result); 

        // по-дълъг вариант за Assert на колекцията
        Assert.That(result[0], Is.EqualTo(3));
        Assert.That(result[1], Is.EqualTo(4));
        Assert.That(result[2], Is.EqualTo(6));
        Assert.That(result[3], Is.EqualTo(8));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new() { 303, 44, 6006, 8558 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> numbers = new() { 303, 234, 1001, 506 };
        List<int> expected = new() { 303, 1001 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
