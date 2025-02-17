using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "";
        List<char> igroneChars = new() { 'a', 'b' };

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, igroneChars);

        // Assert 
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        string sentence = "Pesho is 25 years old.";
        List<char> igroneChars = new();

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, igroneChars);

        // Assert 
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "A";
        List<char> igroneChars = new() { 'A' };

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, igroneChars);

        // Assert 
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        string sentence = "Pesho is 25 years old.";
        List<char> igroneChars = new() { 'o', 'a', '.', 'P'};
        string expected = "esh is 25 yers ld";

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, igroneChars);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}
