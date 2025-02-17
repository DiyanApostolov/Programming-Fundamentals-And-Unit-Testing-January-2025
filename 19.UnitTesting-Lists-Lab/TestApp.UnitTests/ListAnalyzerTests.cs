using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = "No elements!";

        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> oneElementList = new() { 42 };
        string expected = "Element count: 1, Min value: 42, Max value: 42, Avg: 42.00.";

        // Act
        string result = ListAnalyzer.Analyze(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> oneElementList = new() { 1, 1, 1, 1 };
        string expected = "Element count: 4, Min value: 1, Max value: 1, Avg: 1.00.";

        // Act
        string result = ListAnalyzer.Analyze(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> oneElementList = new() { 3, 1, 8, 6 };
        string expected = "Element count: 4, Min value: 1, Max value: 8, Avg: 4.50.";

        // Act
        string result = ListAnalyzer.Analyze(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
