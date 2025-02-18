using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyInput = "";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyInput = "  ";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string singleCharInput = "A";
        string expected = "A";

        // Act
        string result = MiddleCharacters.GetMiddleChars(singleCharInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string input = "Potato";
        string expected = "ta";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string input = "table";
        string expected = "b";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
