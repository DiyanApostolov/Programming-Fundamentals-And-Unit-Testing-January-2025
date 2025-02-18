using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new() { 1.50, 1.80, 2.20 };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new() { 6.50, 6, 7 };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 2.50, 2.80, 2, 3 })]
    [TestCase(new double[] { 2, 2, 2 })]
    [TestCase(new double[] { 2.99, 2.99, 2.99, 2.99 })]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage(double[] grades)
    {
        // Arrange
        List<double> doubleGrades = grades.ToList();
        string expected = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 3, 3.2, 3.50, 3.15 })]
    [TestCase(new double[] { 3, 3, 3 })]
    [TestCase(new double[] { 3.49, 3.49, 3.48, 3.50 })]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage(double[] grades)
    {
        // Arrange
        List<double> doubleGrades = grades.ToList();
        string expected = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrades);

        // Assert
        Assert.That(result, Is.EqualTo(expected), "Something wrong");
    }

    [TestCase(new double[] { 3, 5, 3.50, 4.20 })]        // middle scenario
    [TestCase(new double[] { 3.50, 3.50, 3.50 })]        // down border 
    [TestCase(new double[] { 4.49, 4.49, 4.48, 4.50 })]  // up border
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage(double[] grades)
    {
        // Arrange
        List<double> doubleGrades = grades.ToList();
        string expected = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 4, 6, 4.50, 5.20 })]        // middle scenario
    [TestCase(new double[] { 4.50, 4.50, 4.50 })]        // down border 
    [TestCase(new double[] { 5.49, 5.49, 5.48, 5.50 })]  // up border
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage(double[] grades)
    {
        // Arrange
        List<double> doubleGrades = grades.ToList();
        string expected = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 5.30, 6, 5.80, 5.70 }, "Error: middle scenarioo")]   
    [TestCase(new double[] { 5.50, 5.50, 5.50 }, "Error: down border")]    
    [TestCase(new double[] { 6, 6, 6, 6 }, "Error: up border")]           
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage(double[] grades, string errorMessage)
    {
        // Arrange
        List<double> doubleGrades = grades.ToList();
        string expected = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrades);

        // Assert
        Assert.That(result, Is.EqualTo(expected), errorMessage);
    }
}
