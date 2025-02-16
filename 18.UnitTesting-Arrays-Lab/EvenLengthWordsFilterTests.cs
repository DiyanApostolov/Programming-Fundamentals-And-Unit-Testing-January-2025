using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();
        string expected = string.Empty; // ""

        // Act
        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arrange
        string[] inputArray = new string[] { "abc" };
        string expected = string.Empty;

        // Act
        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arrange
        string[] inputArray = new string[] { "abc", "abcde" };
        string expected = string.Empty;

        // Act
        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arrange
        string[] inputArray = new string[] { "abcd" };
        string expected = "abcd";

        // Act
        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arrange 
        string[] inputArray = new string[] { "abc", "abcd", "abcde", "abcdef" };
        string expected = "abcd abcdef";

        // Act
        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

